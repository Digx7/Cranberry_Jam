using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionManager : MonoBehaviour
{

    [SerializeField] private string tagThatHurtsMe,
                                    tagThatIHurt;

    [SerializeField] private GameObject objectThatHurtMe,
                                        objectThatIHurt;

    [SerializeField] private UnityEvent GotHit;
    [SerializeField] private UnityEvent DidDamage;

    public bool CanThisHurtMe(Collision col){
      if(col.gameObject.tag == tagThatHurtsMe) return true;
      else return false;
    }

    public bool CanThisHurtMe(Collider col){
      if(col.gameObject.tag == tagThatHurtsMe) return true;
      else return false;
    }

    public bool CanIHurtThis(Collision col){
      if(col.gameObject.tag == tagThatIHurt) return true;
      else return false;
    }

    public bool CanIHurtThis(Collider col){
      if(col.gameObject.tag == tagThatIHurt) return true;
      else return false;
    }

    public void OnCollisionEnter(Collision col){
      if(CanThisHurtMe(col)){
        Debug.Log("Ouch");
        objectThatHurtMe = col.gameObject;
        GotHit.Invoke();
      } else if(CanIHurtThis(col)){
        Debug.Log("Take that");
        objectThatIHurt = col.gameObject;
        DidDamage.Invoke();
      }
    }

    public void OnTriggerEnter(Collider col){
      if(CanThisHurtMe(col)){
        Debug.Log("Ouch");
        objectThatHurtMe = col.gameObject;
        GotHit.Invoke();
      } else if(CanIHurtThis(col)){
        Debug.Log("Take that");
        objectThatIHurt = col.gameObject;
        DidDamage.Invoke();
      }
    }

    public GameObject GetObjectThatHurtMe(){
      return objectThatHurtMe;
    }

    public GameObject GetObjectThatIHurt(){
      return objectThatIHurt;
    }
}
