// Digx7
// Finds The player objects
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayerObject : MonoBehaviour
{
    [SerializeField] private GameObject player01,
                                        player02;

    [SerializeField] private bool targetPlayer01 = true;

    public void Awake(){
      FindPlayers();
    }

    public void FindPlayers(){
      if (player01 == null || player02 == null)
      {
          GameObject[] _player01 = GameObject.FindGameObjectsWithTag("Player01");
          GameObject[] _player02 = GameObject.FindGameObjectsWithTag("Player02");

          int i = 1;
          if (i == _player01.Length && i == _player02.Length)
          {
              player01 = _player01[0];
              player02 = _player02[0];
          }
          else StartCoroutine("waitForPlayerToSpawn");
      }
    }

    public IEnumerator waitForPlayerToSpawn(){
        int i = 1;
        GameObject[] _player;
        do
        {
            _player = GameObject.FindGameObjectsWithTag("Player01");
            yield return null;
        } while (i != _player.Length);

        FindPlayers();

        yield return null;
    }

    public GameObject getPlayer01(){
      return player01;
    }

    public GameObject getPlayer02(){
      return player02;
    }

    public GameObject getTargetPlayer(){
      if(targetPlayer01) return player01;
      else return player02;
    }
}
