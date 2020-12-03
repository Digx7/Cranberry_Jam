using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class LeaderboardManager
{
    //[SerializeField] private Score highestScore;
    private const string PATHNAME = "/leaderboard.save";

    // ---HighScore---
    /*
    public void setHighestScore(Score input){
      highestScore = input;
    }

    public Score getHighestScore(){
      return highestScore;
    }

    public bool isThisANewHighScore(Score input){
      if(input.getScore() > highestScore.getScore()) return true;
      else return false;
    }
    */
    // ---Score---

    public static void saveScore(Score input){
      //if (isThisANewHighScore(input)) setHighestScore(input);

      Leaderboard currentLeaderboard = loadLeaderboard();

      currentLeaderboard.addNewScoreToLeaderboard(input);
      currentLeaderboard.sortLeaderboard();

      saveLeaderboard(currentLeaderboard);
    }

    public static void saveScore(string name, float value){
      //if (isThisANewHighScore(input)) setHighestScore(input);

      Score _score = new Score(name, value);

      Leaderboard currentLeaderboard = loadLeaderboard();

      currentLeaderboard.addNewScoreToLeaderboard(_score);
      currentLeaderboard.sortLeaderboard();

      saveLeaderboard(currentLeaderboard);
    }

    public static Score LoadHighScore(){
      if(isThereASavedLeaderboard()) return loadLeaderboard().getHighScoreOnLeaderBoard();
      else return new Score();
    }

    /*public Score loadScore(int index){

    }

    public Score loadScore(string name){

    }*/

    // ---Leaderboard---

    public static void saveLeaderboard(Leaderboard input){
      string path = Application.persistentDataPath + PATHNAME;
      BinaryFormatter formatter = new BinaryFormatter();
      FileStream stream = new FileStream(path, FileMode.Create);

      formatter.Serialize(stream, input);
      stream.Close();
    }

    public static void saveNewLeaderboard(){
      Leaderboard newLeaderboard = new Leaderboard();

      saveLeaderboard(newLeaderboard);
    }

    public static void deleteLeaderboard(){
      string path = Application.persistentDataPath + PATHNAME;
      FileStream stream = new FileStream(path, FileMode.Truncate);

      stream.Close();
    }

    public static bool isThereASavedLeaderboard(){
      string path = Application.persistentDataPath + PATHNAME;
      if (File.Exists(path)){
        return true;
      } else {
        return false;
      }
    }

    public static Leaderboard loadLeaderboard(){
      string path = Application.persistentDataPath + PATHNAME;

      if (isThereASavedLeaderboard()){
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        Leaderboard _leaderboard = formatter.Deserialize(stream) as Leaderboard;
        stream.Close();

        return _leaderboard;
      }else{
        Debug.Log("There is no save data at : " + path);
        return new Leaderboard();
      }
    }
}
