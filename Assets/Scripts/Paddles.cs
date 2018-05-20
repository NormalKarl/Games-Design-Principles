using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour {

    //Active CameraMovement script
    public CameraMovement CameraController;
    //The rotation speed of this paddle.
    public float RotationSpeed; 

	// Update is called once per frame
	void Update () {
        //Check if camera controller is not null and playing.
        if(CameraController != null && CameraController.Playing)
        {
            //Set the new rotation as a new Quaternion.
            Quaternion quat = transform.localRotation;
            Vector3 eul = new Vector3(0, 0, quat.eulerAngles.z + RotationSpeed);
            quat.eulerAngles = eul;
            transform.localRotation = quat;
        }


    }
}
