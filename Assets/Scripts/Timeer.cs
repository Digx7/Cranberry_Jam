using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timeer : MonoBehaviour
{
    [SerializeField] private float timeToWaitFor = 1.0f;
    [SerializeField] private float time;
    [SerializeField] private bool hasBeenTriggered = false;
    [SerializeField] private UnityEvent timeMet;

    public void Update(){
      if(!hasBeenTriggered){
        if(time < timeToWaitFor){
          time += Time.deltaTime;
        }else {
          timeMet.Invoke();
          hasBeenTriggered = true;
        }
      }
    }
}
