using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject objectToDestroy;
    [SerializeField] private bool destroyOnAwake;
    [SerializeField] private float destroyDelayTime;

    public void Awake(){
      if(destroyOnAwake) ObjectDestroy(objectToDestroy, destroyDelayTime);
    }

    public void ObjectDestroy(GameObject _object, float _time){
      Destroy(_object,_time);
    }

    public void ObjectDestroy(GameObject _object){
      Destroy(_object);
    }

    public void PlayerKilledEnemy(GameObject player){
      CollisionManager _collisionManager = player.GetComponent<CollisionManager>();
      _collisionManager.GetObjectThatIHurt().GetComponent<SingleEnemyAiManager>().EnemyDie();
    }
}
