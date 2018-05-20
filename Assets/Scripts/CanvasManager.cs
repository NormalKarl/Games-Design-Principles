using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {
    
    public CameraMovement CameraController;
    public GameObject OnStartRemoveObject;
    
    //Play action.
    public void playAction() {
        //Hide this main menu canvas
        GetComponent<Canvas>().enabled = false;

        //Check if the start remove object is actually set and then destroy it.
        if (OnStartRemoveObject != null)
            Destroy(OnStartRemoveObject);

        //Check if the camera controller is set and start the machine.
        if (CameraController != null)
        {
            //Reset camera so it starts back at the first object with 0 time.
            CameraController.ResetCamera();
            CameraController.Playing = true;
        }
    }

    //Exit action.
    public void exitAction()
    {
        //Close game.
        Application.Quit();
    }

}
