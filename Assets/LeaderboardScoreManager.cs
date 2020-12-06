using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI initials,
                                       score;

    public void setAllText(string _initials, string _score){
      setInitials(_initials);
      setScore(_score);
    }

    public void setAllText(string _initials, float _score){
      setInitials(_initials);
      setScore(_score);
    }

    public void setAllText(Score input){
      setInitials(input.getInitials());
      setScore(input.getScore());
    }

    public void setInitials(string input){
      initials.text = input;
    }

    public void setScore(string input){
      score.text = input;
    }

    public void setScore(float input){
      score.text = "" + input;
    }
}
