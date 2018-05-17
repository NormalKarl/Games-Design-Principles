using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBullseye : MonoBehaviour {

    public Transform[] CheckObjects;
    public Transform RemoveObject;

    public void OnTriggerEnter(Collider other)
    {

        foreach(Transform transform in CheckObjects)
        {
            if (GameObject.ReferenceEquals(transform.gameObject, other.gameObject))
            {
                Destroy(RemoveObject.gameObject);
            }
        }
    }



}
