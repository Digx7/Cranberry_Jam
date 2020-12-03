using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Score : IComparable
{
   [SerializeField] private string initials;
   [SerializeField] private float score;

   public void setInitials(string input){
     initials = input;
   }

   public void setScore(float input){
     score = input;
   }

   public string getInitials(){
     return initials;
   }

   public float getScore(){
     return score;
   }

   public Score(string _initials, float _score){
     initials = _initials;
     score = _score;
   }

   public Score(){
     initials = "AAA";
     score = 0;
   }

   public int ComapareTo(Score _score){
     if (_score == null) return 1;

    Score otherScore = _score as Score;
    if (otherScore != null)
        return this.score.CompareTo(otherScore.getScore());
    else
       throw new ArgumentException("Object is not a Temperature");
   }
}
