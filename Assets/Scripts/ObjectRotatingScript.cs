using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotatingScript : MonoBehaviour
{
    [SerializeField] private GameObject objectToRotate;
    [SerializeField] private float xRotationSpeed,
                                   yRotationSpeed,
                                   zRotationSpeed;

    public void Awake(){
      if(objectToRotate == null) objectToRotate = gameObject;
    }

    public void FixedUpdate(){
      objectToRotate.transform.Rotate (xRotationSpeed*Time.deltaTime,yRotationSpeed*Time.deltaTime,zRotationSpeed*Time.deltaTime);
    }
}
