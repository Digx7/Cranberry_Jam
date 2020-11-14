// Digx7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    /* Description --
     *  This script will handel the player inputs
     */

    public CharacterMovement CharacterMovement01, CharacterMovement02;//references the player script
    //inputactions
    public Player Player; // is the input action map
    private GameObject _Player01, _Player02;

    // this function will run at the start of the scene
    public void Awake(){
        Player = new Player();

        Rebind();
    }

    // this function will bind the needed variables to the player prefab
    public void Rebind(){
        // if player is not set in inspector then it will auto set
        if (_Player01 == null || _Player02 == null)
        {
            GameObject[] _player01 = GameObject.FindGameObjectsWithTag("Player01");
            GameObject[] _player02 = GameObject.FindGameObjectsWithTag("Player02");

            int i = 1;
            if (i == _player01.Length && i == _player02.Length)
            {
                _Player01 = _player01[0];
                _Player02 = _player02[0];

                BindInputs();
            }
            else StartCoroutine("waitForPlayerToSpawn");
        }
    }

    public void BindInputs (){
        if (CharacterMovement01 == null || CharacterMovement02 == null)
        {
            CharacterMovement01 = _Player01.GetComponent<CharacterMovement>();
            CharacterMovement02 = _Player02.GetComponent<CharacterMovement>();
        }


        Player.Main.MovePlayer01.performed += ctx => CharacterMovement01.MovePlayer(ctx.ReadValue<Vector2>());;//ties inputs to given values
        Player.Main.MovePlayer02.performed += ctx => CharacterMovement02.MovePlayer(ctx.ReadValue<Vector2>());// test
    }

    public IEnumerator waitForPlayerToSpawn(){
        int i = 1;
        GameObject[] _player;
        do
        {
            _player = GameObject.FindGameObjectsWithTag("Player01");
            yield return null;
        } while (i != _player.Length);

        Rebind();
        BindInputs();

        yield return null;
    }

    // this function will enabled the inputsystem when this gameObject is enabled
    private void OnEnable(){
      Player.Enable();
    }

    // this function will disabled the inputsystem when this gameObject is disabled
    private void OnDisable(){
      Player.Disable();
    }

}
