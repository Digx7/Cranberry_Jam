using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager
{
    [SerializeField] private Score highestScore;

    public void setHighestScore(Score input){
      highestScore = input;
    }

    public Score getHighestScore(){
      return highestScore;
    }

    //public void 
}
