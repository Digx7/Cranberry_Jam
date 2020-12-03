using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // --- PlayUi---
    [SerializeField] private TextMeshProUGUI scoreTMP,
                                             livesTMP,
                                             bombsTMP,
                                             musicTMP;
    [SerializeField] private const string SCORETEXT = "Score : ",
                                          LIVESTEXT = "Lives : ",
                                          BOMBSTEXT = "",
                                          MUSICTEXT = "";

    // --- GameOverUi---
    [SerializeField] private TextMeshProUGUI yourScoreTMP,
                                             highScoreTMP,
                                             _yourScoreTMP,
                                             _highScoreTMP;
    [SerializeField] private const string YOURSCORETEXT = "Score : ",
                                          HIGHSCORETEXT = "Best : ";

    [SerializeField] private GameObject PlayUi,
                                        GameOverUi,
                                        SaveScore;

    // ---Score--------------------------
    public void UpdateScore(string input){
      scoreTMP.text = SCORETEXT + input;
      yourScoreTMP.text = YOURSCORETEXT + input;
      _yourScoreTMP.text = YOURSCORETEXT + input;
    }

    public void UpdateScore(int input){
      scoreTMP.text = SCORETEXT + input;
      yourScoreTMP.text = YOURSCORETEXT + input;
      _yourScoreTMP.text = YOURSCORETEXT + input;
    }

    // ---HighScore----------------------
    public void UpdateHighScore(string input){
      highScoreTMP.text = HIGHSCORETEXT + input;
      _highScoreTMP.text = HIGHSCORETEXT + input;
    }

    public void UpdateHighScore(int input){
      highScoreTMP.text = HIGHSCORETEXT + input;
      _highScoreTMP.text = HIGHSCORETEXT + input;
    }

    public void UpdateHighScore(float input){
      highScoreTMP.text = HIGHSCORETEXT + input;
      _highScoreTMP.text = HIGHSCORETEXT + input;
    }

    // ---Lives----------
    public void UpdateLives(string input){
      livesTMP.text = LIVESTEXT + input;
    }

    public void UpdateLives(int input){
      livesTMP.text = LIVESTEXT + input;
    }

    // ---Bombs--------
    public void UpdateBombs(string input){
      bombsTMP.text = BOMBSTEXT + input;
    }

    public void UpdateBombs(int input){
      bombsTMP.text = BOMBSTEXT + input;
    }

    // ---Music---------
    public void UpdateMusic(string input){
      musicTMP.text = MUSICTEXT + input;
    }

    public void UpdateMusic(int input){
      musicTMP.text = MUSICTEXT + input;
    }

    // ---SetMode---------------------------------
    public void SetPlayMode(){
      PlayUi.SetActive(true);
      GameOverUi.SetActive(false);
      SaveScore.SetActive(false);
    }

    public void SetGameOverMode(){
      PlayUi.SetActive(false);
      GameOverUi.SetActive(true);
      SaveScore.SetActive(false);
    }

    public void SetSaveScoreMode(){
      PlayUi.SetActive(false);
      GameOverUi.SetActive(false);
      SaveScore.SetActive(true);
    }

    // ---OnClick---------------------------------
    public void OnClickExit(){
      SceneManager.LoadScene("MainMenu");
    }

    public void OnClickRetry(){
      SceneManager.LoadScene("Main");
    }

    public void OnClickSaveScore(){
      SetSaveScoreMode();
    }
}
