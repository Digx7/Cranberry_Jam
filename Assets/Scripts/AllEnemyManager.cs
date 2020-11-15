using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject[] all01Enemys,
                                          all02Enemys,
                                          allEnemySpawning;
    [SerializeField] private GameObject codeHolder;

    public void DestoryAllEnemys(){
      FindAllEnemys();
      foreach(GameObject enemy in all01Enemys){
        if(enemy != null)
          enemy.GetComponent<SingleEnemyAiManager>().EnemyDie();
      }
      foreach(GameObject enemy in all02Enemys){
        if(enemy != null)
          enemy.GetComponent<SingleEnemyAiManager>().EnemyDie();
      }
      foreach(GameObject enemy in allEnemySpawning){
        if(enemy != null)
          Destroy(enemy);
      }
    }

    public void FindAllEnemys(){
      all01Enemys = GameObject.FindGameObjectsWithTag("Enemy 01");
      all02Enemys = GameObject.FindGameObjectsWithTag("Enemy 02");
      allEnemySpawning = GameObject.FindGameObjectsWithTag("Enemy Spawning");
    }
}
