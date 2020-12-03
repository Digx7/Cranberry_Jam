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

    public Score getHighScoreOnLeaderBoard(){
      return getScoreOnLeaderBoard(0);
    }

    public Score getScoreOnLeaderBoard(int index){
      if(index <= _leaderboard.Count - 1)
      return _leaderboard[index];
      else return new Score();
    }

    public int getCount(){
      return _leaderboard.Count;
    }

    public Leaderboard(List<Score> input){
      setLeaderboard(input);
    }

    public Leaderboard(){
      _leaderboard = new List<Score>();
    }

    public void addNewScoreToLeaderboard(Score newScore){
      _leaderboard.Add(newScore);
    }

    public void sortLeaderboard(){
      _leaderboard.Sort();
    }

    public void erase(){
      _leaderboard.Clear();
    }
}
