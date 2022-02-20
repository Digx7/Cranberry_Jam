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
      [SerializeField] private bool dragAllowed;
      [SerializeField] private Collider col;

    [Header ("Events --------------")]
      [SerializeField] private UnityEvent playerStartMoving;
      [SerializeField] private UnityEvent playerStopMoving;

    public void Awake(){
      if(rb == null) rb = gameObject.GetComponent<Rigidbody>();
      col = GetComponent<Collider>();
    }

    public void Update(){
      DragAndDropPlayer();
    }

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

    public void DragAndDropPlayer(){
      if(Input.touchCount > 0){
        Touch touch = Input.GetTouch(0);
        Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

        if(touch.phase == TouchPhase.Began){
          Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
          if (col == touchedCollider){
            dragAllowed = true;
          }
        }

        if(touch.phase == TouchPhase.Moved){
          if (dragAllowed){
            transform.position = new Vector2(touchPosition.x, touchPosition.y);
          }
        }

        if(touch.phase == TouchPhase.Ended){
          dragAllowed = false;
        }
      }
    }

    public Vector3 GetDirectionBetweenToObjects(GameObject object1, GameObject object2){
      Vector3 returnValue = object1.transform.position - object2.transform.position;
      returnValue = Vector3.Normalize(returnValue);

      return returnValue;
    }


}
