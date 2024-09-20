using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    static public GameObject button;
    // Start is called before the first frame update
    void Awake() {
        button = this.gameObject;
        button.SetActive(false);
        //this.gameObject.SetActive(false);
        //Hide(this.gameObject);
        //.hide();
    }

    
    static public void showRestartButton() {
        button.SetActive(true);
    }
    
}
