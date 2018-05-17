using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour {
    
    public void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-collision.contacts[0].normal * 3000.0f);
    }

}
