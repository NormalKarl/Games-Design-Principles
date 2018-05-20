using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    
    public void ResetMachine()
    {
        //Load Scene 0, effectivly resetting the machine.
        SceneManager.LoadScene(0);
    }

}
