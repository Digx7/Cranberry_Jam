using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
  public void Awake(){
    Time.timeScale = 1.0f;
  }

  public void OnClickPlay(){
    SceneManager.LoadScene("Main");
  }

  public void OnClickQuit(){
    Application.Quit();
  }
}
