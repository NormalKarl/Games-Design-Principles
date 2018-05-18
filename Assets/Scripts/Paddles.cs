using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour {

    public float RotationSpeed; 

	// Update is called once per frame
	void Update () {
        Transform t = GetComponent<Transform>();

        //t.localRotation.SetAxisAngle(new Vector3(0, 0, 1), t.localRotation.z + RotationSpeed);
        //t.localRotation.Set(0, 0, t.localRotation.z + RotationSpeed, 0);
        Quaternion quat = t.localRotation;
        Vector3 eul = quat.eulerAngles;
        eul.Set(0, 0, t.localRotation.eulerAngles.z + RotationSpeed);
        quat.eulerAngles = eul;
        t.localRotation = quat;

    }
}
