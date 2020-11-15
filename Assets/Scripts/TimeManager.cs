using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public void FreezeTime(){
      Time.timeScale = 0.0f;
    }

    public void UnFreezeTime(){
      Time.timeScale = 1.0f;
    }
}
