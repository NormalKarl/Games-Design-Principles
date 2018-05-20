using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    private Canvas canvas;
    public CameraMovement CameraController;
    public GameObject OnStartRemoveObject;

	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Play action.
    public void playAction() {
        canvas.enabled = false;

        if (OnStartRemoveObject != null)
            Destroy(OnStartRemoveObject);

        if (CameraController != null)
        {
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
