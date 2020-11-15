using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTMP,
                                             livesTMP,
                                             bombsTMP,
                                             musicTMP;
    [SerializeField] private const string SCORETEXT = "Score : ",
                                          LIVESTEXT = "Lives : ",
                                          BOMBSTEXT = "",
                                          MUSICTEXT = "";

    [SerializeField] private GameObject PlayUi,
                                        GameOverUi;

    // -----------------------------
    public void UpdateScore(string input){
      scoreTMP.text = SCORETEXT + input;
    }

    public void UpdateScore(int input){
      scoreTMP.text = SCORETEXT + input;
    }

    // -------------
    public void UpdateLives(string input){
      livesTMP.text = LIVESTEXT + input;
    }

    public void UpdateLives(int input){
      livesTMP.text = LIVESTEXT + input;
    }

    // -------------
    public void UpdateBombs(string input){
      bombsTMP.text = BOMBSTEXT + input;
    }

    public void UpdateBombs(int input){
      bombsTMP.text = BOMBSTEXT + input;
    }

    // ------------
    public void UpdateMusic(string input){
      musicTMP.text = MUSICTEXT + input;
    }

    public void UpdateMusic(int input){
      musicTMP.text = MUSICTEXT + input;
    }

    // ------------------------------------
    public void SetPlayMode(){
      PlayUi.SetActive(true);
      GameOverUi.SetActive(false);
    }

    public void SetGameOverMode(){
      PlayUi.SetActive(false);
      GameOverUi.SetActive(true);
    }

    // ------------------------------------
    public void OnClickExit(){
      SceneManager.LoadScene("MainMenu");
    }

    public void OnClickRetry(){
      SceneManager.LoadScene("Main");
    }
}
