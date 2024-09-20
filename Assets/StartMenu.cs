using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // I don't know the best way to implement buttons
    // This here is to be a list of any button related functions
    // It will be attached to the Main Camera.

    public void startButton() {
        Debug.Log("Start Button Pressed");
        SceneManager.LoadScene( "_Scene_0" );
    }
}
