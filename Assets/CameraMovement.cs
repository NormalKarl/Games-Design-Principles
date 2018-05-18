using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    //CamerOffset is used to add additional space to the camera when travelling between
    //FollowObject's. Otherwise the camera may be inside the 
    public Vector3 CameraOffset;
    public FollowObject[] FollowObjects;

    private int objectIndex;
    private float objectTime;

    // Use this for initialization
    void Start () {
        //Set the index and time to 0
        objectIndex = 0;
        objectTime = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        objectTime += Time.deltaTime;
        FollowObject followObj = FollowObjects[objectIndex];

        //Is the current time more then the time spent on that FollowObject?
        if(objectTime >= followObj.WaitTime)
        {
            //Take away the WaitTime (This will keep it in time with the physics.
            //If it sets to 0 it will loose difference in time making it desync with the physics.
            objectTime -= followObj.WaitTime;
            objectIndex++;

            //If the objectIndex is larger then the list then just set to the end.
            if (objectIndex >= FollowObjects.Length)
                objectIndex = FollowObjects.Length - 1;

            //Update object index.
            followObj = FollowObjects[objectIndex];
        }

        //New position variable.
        Vector3 newPosition;

        if (followObj.MovingObject)
        {
            //Set the new position to the current objects position.
            newPosition = followObj.transform.position;
        }
        else
        {
            //Get the current camera position without the offset added on.
            Vector3 cameraFollowPos = (transform.position - CameraOffset);
            Vector3 objectPos = FollowObjects[objectIndex].transform.position;

            //Calculate time between 0 and 1
            float time = objectTime / followObj.WaitTime;

            //Smooth step the position
            //Creates the illusion of a smooth moving camera.
            newPosition = new Vector3(Mathf.SmoothStep(cameraFollowPos.x, objectPos.x, time),
                                            Mathf.SmoothStep(cameraFollowPos.y, objectPos.y, time),
                                            Mathf.SmoothStep(cameraFollowPos.z, objectPos.z, time));

        }

        //Set cameras position to the new position + the camera offset.
        transform.position = newPosition + CameraOffset;
    }
}
