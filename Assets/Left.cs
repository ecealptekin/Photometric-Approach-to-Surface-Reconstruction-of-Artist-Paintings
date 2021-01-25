using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{

  public bool canRotate;

  void Update ()
   {
     if(canRotate)
     {
       StartCoroutine(Rotate(Vector3.right, -5, 1.0f));
     }
   }

  public void StartRotatation()
  {
    canRotate=true;
  }
 
  IEnumerator Rotate( Vector3 axis, float angle, float duration = 1.0f)
  {
     Quaternion from = transform.rotation;
     Quaternion to = transform.rotation;
     to *= Quaternion.Euler( axis * angle );
    
     float elapsed = 0.0f;
     while( elapsed < duration && canRotate)
     {
       transform.rotation = Quaternion.Slerp(from, to, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = to;
     canRotate=false;
   }

 }
