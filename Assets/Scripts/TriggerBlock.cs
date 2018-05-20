using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlock : MonoBehaviour {

    public GameObject[] TestObjects;
    public GameObject PhysicsObject;
    
    public void OnTriggerEnter(Collider collider)
    {
        //Loop through all of the GameObject's
        foreach(GameObject obj in TestObjects)
        {
            //Test if any of the objects in the TestObjects list actually collide.
            if (ReferenceEquals(obj, collider.gameObject))
            {
                //This will set the objects physics to effectivly be enabled.
                PhysicsObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

}
