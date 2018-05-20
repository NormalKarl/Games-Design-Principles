using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour {

    public CameraMovement CameraController;
    public float RotationSpeed; 

	// Update is called once per frame
	void Update () {
        //Chekc if camera controller is not null and playing.
        if(CameraController != null && CameraController.Playing)
        {
            Quaternion quat = transform.localRotation;
            Vector3 eul = new Vector3(0, 0, quat.eulerAngles.z + RotationSpeed);
            quat.eulerAngles = eul;
            transform.localRotation = quat;
        }


    }
}
