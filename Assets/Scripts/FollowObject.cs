using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    //The amount of time the camera should focus on this GameObject.
    public float WaitTime;
    //Tells the CameraMovement script if this is a moving object.
    //I.E Moving sphere or static camera position.
    public bool MovingObject;

}
