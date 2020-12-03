using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int lives;
    [SerializeField] private int bombs;
    [SerializeField] private string initials;
    [SerializeField] private Score highScore;

    [SerializeField] private TimeManager _timeManager;
    [SerializeField] private AllEnemyManager _allEnemyManager;
    [SerializeField] private UIManager _uiManager;


    // --- Update/Awake ---

    public void Awake(){
      if(_timeManager == null) _timeManager = gameObject.GetComponent<TimeManager>();
      if(_allEnemyManager == null) _allEnemyManager = gameObject.GetComponent<AllEnemyManager>();
      if(_uiManager == null) _uiManager = gameObject.GetComponent<UIManager>();

      LoadHighScore();

      UpdateAllUI();

      _timeManager.UnFreezeTime();
    }

    // --- initials ---

    public void setInitials(string input){
      initials = input;
    }

    public string getInitials(){
      return initials;
    }

    // --- HighScore ---

    public void setHighestScore(Score input){
      highScore = input;
    }

    public Score getHighScore(){
      return highScore;
    }

    public float getHighScoreValue(){
      return highScore.getScore();
    }

    public string getHighScoreInitials(){
      return highScore.getInitials();
    }

    // --- Score ---

    public void IncrementScore(){
      score++;
      UpdateScoreUI();
    }

    public void DecrementScore(){
      score--;
      UpdateScoreUI();
    }

    public void SetScore(int input){
      score = input;
      UpdateScoreUI();
    }

    // --- Lives ---

    public void IncrementLives(){
      lives++;
      UpdateLivesUI();
    }

    public void DecrementLives(){
      lives--;
      UpdateLivesUI();
    }

    public void SetLives(int input){
      lives = input;
      UpdateLivesUI();
    }

    // --- Bombs ---

    public void IncrementBombs(){
      bombs++;
      UpdateBombsUI();
    }

    public void DecrementBombs(){
      bombs--;
      UpdateBombsUI();
    }

    public void SetBombs(int input){
      bombs = input;
      UpdateBombsUI();
    }

    // --- UI ---

    public void UpdateAllUI(){
      UpdateLivesUI();
      UpdateBombsUI();
      UpdateScoreUI();
      UpdateMusicUI();
    }

    public void UpdateLivesUI(){
      _uiManager.UpdateLives(lives);
    }

    public void UpdateBombsUI(){
      _uiManager.UpdateBombs(bombs);
    }

    public void UpdateScoreUI(){
      _uiManager.UpdateScore(score);
      _uiManager.UpdateHighScore(getHighScoreValue());
    }

    public void UpdateMusicUI(){
      //_uiManager.UpdateMusic();
    }

    // --- Game States ---

    // What happens when the player loses all lives
    public void GameOver(){
      _timeManager.FreezeTime();
      _uiManager.SetGameOverMode();

      // Should ask if player wants to save score
      // If so they sould save the score
      // If not do nothing
    }

    // --- Game Events ---

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

    public void SavePlayerScore(){
      LeaderboardManager.saveScore(initials, score);
    }

    public void LoadHighScore(){
      highScore = LeaderboardManager.LoadHighScore();
    }
}
