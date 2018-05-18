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
            //t.localRotation.SetAxisAngle(new Vector3(0, 0, 1), t.localRotation.z + RotationSpeed);
            //t.localRotation.Set(0, 0, t.localRotation.z + RotationSpeed, 0);
            Quaternion quat = transform.localRotation;
            Vector3 eul = quat.eulerAngles;
            eul.Set(0, 0, transform.localRotation.eulerAngles.z + RotationSpeed);
            quat.eulerAngles = eul;
            transform.localRotation = quat;
        }


    }
}
