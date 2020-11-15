using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleEnemyAiManager : MonoBehaviour
{
    [SerializeField] private FindPlayerObject _findPlayerObject;
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private GameObject targetPlayer;
    [SerializeField] private GameObject deathSparks;

    public void Start(){
      if(_findPlayerObject == null){
        _findPlayerObject = gameObject.GetComponent<FindPlayerObject>();
      }
      if(_characterMovement == null){
        _characterMovement = gameObject.GetComponent<CharacterMovement>();
      }
      if(targetPlayer == null){
        setTargetPlayer();
      }
    }

    public void FixedUpdate(){
      MoveEnemy();
    }

    public void setTargetPlayer(){
      targetPlayer = _findPlayerObject.getTargetPlayer();
    }

    public void MoveEnemy(){
      _characterMovement.MovePlayer(_characterMovement.GetDirectionBetweenToObjects(targetPlayer, gameObject));
    }

    public void EnemyDie(){
      Instantiate(deathSparks, gameObject.transform.position, Quaternion.identity);
      Destroy(gameObject);
    }
}
