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
    [SerializeField] private UIManager _uiManager;

    public void Awake(){
      if(_timeManager == null) _timeManager = gameObject.GetComponent<TimeManager>();
      if(_allEnemyManager == null) _allEnemyManager = gameObject.GetComponent<AllEnemyManager>();
      if(_uiManager == null) _uiManager = gameObject.GetComponent<UIManager>();

      UpdateUI();
    }

    public void IncrementScore(){
      score++;
      UpdateUI();
    }

    public void DecrementScore(){
      score--;
      UpdateUI();
    }

    public void SetScore(int input){
      score = input;
      UpdateUI();
    }

    public void IncrementLives(){
      lives++;
      UpdateUI();
    }

    public void DecrementLives(){
      lives--;
      UpdateUI();
    }

    public void SetLives(int input){
      lives = input;
      UpdateUI();
    }

    public void IncrementBombs(){
      bombs++;
      UpdateUI();
    }

    public void DecrementBombs(){
      bombs--;
      UpdateUI();
    }

    public void SetBombs(int input){
      bombs = input;
      UpdateUI();
    }

    public void UpdateUI(){
      _uiManager.UpdateLives(lives);
      _uiManager.UpdateBombs(bombs);
      _uiManager.UpdateScore(score);
      //_uiManager.UpdateMusic()
    }

    // What happens when the player loses all lives
    public void GameOver(){
      _timeManager.FreezeTime();
      _uiManager.SetGameOverMode();
    }

    // What happens when the player loses One life
    public void PlayerLoseALife(){
      DecrementLives();
      if(lives < 0){
        GameOver();
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
