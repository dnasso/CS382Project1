using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundTracker : MonoBehaviour
{
    static private Text     _UI_TEXT;
    static private int      _ROUND_NUMBER = 1;

    void Awake()
    {
        _UI_TEXT = GetComponent<Text>();
        _UI_TEXT.text = "Round: " + _ROUND_NUMBER.ToString("#,0");
    }

    static public void INCREMENT_ROUND_COUNTER() {
        if( _ROUND_NUMBER >= 4 ) 
        {
            _UI_TEXT.text = "GAME OVER";
            //RestartButton.showRestartButton();
        }
        
        else 
        {
            _ROUND_NUMBER += 1;
            _UI_TEXT.text = "Round: " + _ROUND_NUMBER.ToString("#,0");
        }


    }

    /*
    // I wrote myself into a corner with my code. Welcome this redundancy
    static public void GAME_OVER() {
        // If a game over state happens
        _UI_TEXT.text = "GAME OVER";
    }
    */

    static public void RESET_ROUND_COUNTER() {
        
        _ROUND_NUMBER = 1;
        _UI_TEXT.text = "Round: " + _ROUND_NUMBER.ToString("#,0");
        
    }
}
