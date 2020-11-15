using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int lives;
    [SerializeField] private int bombs;

    [SerializeField] private TimeManager _timeManager;
    [SerializeField] private AllEnemyManager _allEnemyManager;

    public void Awake(){
      if(_timeManager == null) _timeManager = gameObject.GetComponent<TimeManager>();
      if(_allEnemyManager == null) _allEnemyManager = gameObject.GetComponent<AllEnemyManager>();
    }

    public void IncrementScore(){
      score++;
    }

    public void DecrementScore(){
      score--;
    }

    public void SetScore(int input){
      score = input;
    }

    public void IncrementLives(){
      lives++;
    }

    public void DecrementLives(){
      lives--;
    }

    public void SetLives(int input){
      lives = input;
    }

    public void IncrementBombs(){
      bombs++;
    }

    public void DecrementBombs(){
      bombs--;
    }

    public void SetBombs(int input){
      bombs = input;
    }


    // What happens when the player loses One life
    public void PlayerLoseALife(){
      DecrementLives();
      if(lives < 0){
        // Game over
      }else{
        StartCoroutine(PlayerLostALife());
      }
    }

    public IEnumerator PlayerLostALife(){
      _timeManager.FreezeTime();
      yield return new WaitForSecondsRealtime(0.5f);
      _allEnemyManager.DestoryAllEnemys();
      yield return new WaitForSecondsRealtime(0.5f);
      _timeManager.UnFreezeTime();
    }
}
