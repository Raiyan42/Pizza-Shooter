using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     void OnTriggerEnter(Collider collider) 
     {
         if(collider.gameObject.tag == "Player")
         {
             // destroy this object
             Destroy(collider.gameObject);
         }
     }
}
