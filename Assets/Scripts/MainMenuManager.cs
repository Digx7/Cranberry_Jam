using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
  [SerializeField] private GameObject LeaderboardStartPoint,
                                      LeaderboardElement;

  public void Awake(){
    Time.timeScale = 1.0f;
    RenderLeaderboard(LeaderboardManager.loadLeaderboard());
  }

  public void OnClickPlay(){
    SceneManager.LoadScene("Main");
  }

  public void OnClickQuit(){
    Application.Quit();
  }

  public void RenderLeaderboard(Leaderboard input){
    Debug.Log("Rendering Leaderboard");

    for (int i = 0; i <= input.getCount(); i++){
      Vector3 elementPos = new Vector3 (0, -i*25, 0);
      //GameObject element = Instantiate(LeaderboardElement, elementPos, Quaternion.identity, LeaderboardStartPoint.transform);

      GameObject element =  Instantiate(LeaderboardElement, LeaderboardStartPoint.transform);
      element.transform.localPosition = elementPos;

      element.GetComponent<LeaderboardScoreManager>().setAllText(input.getScoreOnLeaderBoard(i));

      if(i == 14) break;
    }
  }
}
