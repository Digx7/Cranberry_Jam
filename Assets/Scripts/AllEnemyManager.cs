using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemyManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> allEnemys;
    [SerializeField] private GameObject codeHolder;

    public void DestoryAllEnemys(){
      foreach(GameObject enemy in allEnemys){
        if(enemy != null)
          enemy.GetComponent<SingleEnemyAiManager>().EnemyDie();
      }
    }
}
