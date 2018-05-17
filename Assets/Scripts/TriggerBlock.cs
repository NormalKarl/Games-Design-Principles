using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlock : MonoBehaviour {

    public GameObject[] TestObjects;
    public GameObject PhysicsObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collider)
    {
        foreach(GameObject obj in TestObjects)
        {
            if (ReferenceEquals(obj, collider.gameObject))
            {
                PhysicsObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

}
