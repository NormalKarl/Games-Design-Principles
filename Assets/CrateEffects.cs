using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateEffects : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<AudioSource>() != null && !GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }

}
