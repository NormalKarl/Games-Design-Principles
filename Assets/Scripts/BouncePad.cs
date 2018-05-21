using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour {
    
    public void OnCollisionEnter(Collision collision)
    {
        //Get the other collision rigid body and apply the inverse contact normal multiplied by 3000.0f
        collision.rigidbody.AddForce(-collision.contacts[0].normal * 3000.0f);

        //If the sound effect is not null, play it.
        if (GetComponent<AudioSource>() != null)
            GetComponent<AudioSource>().Play();
    }

}
