//Digx7
//Handles the movement of any given character
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement : MonoBehaviour
{
    [Header ("Main -----------------")]
      [SerializeField] private Rigidbody rb;
      [SerializeField] private float speed;
      [SerializeField] private bool isMoving;

    [Header ("Events --------------")]
      [SerializeField] private UnityEvent playerStartMoving;
      [SerializeField] private UnityEvent playerStopMoving;

    // Move Playerr scripts
    public void MovePlayer(Vector3 input){
      rb.velocity = input * speed * Time.deltaTime;

      if (isMoving == false)
      {
        if (input.x != 0 || input.y != 0)
        {
          playerStartMoving.Invoke();
          isMoving = true;
        }
      }
      else
      {
        if (input.x == 0 && input.y == 0)
        {
          playerStopMoving.Invoke();
          isMoving = false;
        }
      }
    }

    public void MovePlayer(Vector2 input){
      rb.velocity = new Vector3(input.x,input.y) * speed * Time.deltaTime;

      if (isMoving == false)
      {
        if (input.x != 0 || input.y != 0)
        {
          playerStartMoving.Invoke();
          isMoving = true;
        }
      }
      else
      {
        if (input.x == 0 && input.y == 0)
        {
          playerStopMoving.Invoke();
          isMoving = false;
        }
      }
    }
}
