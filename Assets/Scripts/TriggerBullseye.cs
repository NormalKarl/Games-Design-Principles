using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBullseye : MonoBehaviour {

    public Transform[] CheckObjects;
    public Transform RemoveObject;

    public void OnTriggerEnter(Collider other)
    {

        //Loop through all of the test objects.
        foreach (Transform transform in CheckObjects)
        {
            //Test if the colliding object matches the object.
            if (ReferenceEquals(transform.gameObject, other.gameObject))
            {
                //If the RemoveObject doesn't equal null then destroy it.
                if(RemoveObject != null)
                {
                    Destroy(RemoveObject.gameObject);
                }
            }
        }
    }



}
