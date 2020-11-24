using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Leaderboard
{
    [SerializeField] private List<Score> _leaderboard;

    public void setLeaderboard(List<Score> input){
      _leaderboard = input;
    }

    public List<Score> getLeaderboard(){
      return _leaderboard;
    }

    public Leaderboard(List<Score> input){
      setLeaderboard(input);
    }

    public Leaderboard(){

    }

    public void addNewScoreToLeaderboard(Score newScore){
      _leaderboard.Add(newScore);
    }

    public void sortLeaderboard(){
      _leaderboard.Sort();
    }
}
