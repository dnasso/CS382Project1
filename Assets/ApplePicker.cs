using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject       basketPrefab;
    public int              numBaskets      = 3;
    public float            basketBottomY   = -14f;
    public float            basketSpacingY  = 2f;
    public bool             gameOver = false;
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++) {
            GameObject tBasketGO = Instantiate<GameObject>( basketPrefab );
            Debug.Log("Basket instantiated");
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i );
            tBasketGO.transform.position = pos;
            basketList.Add( tBasketGO );
        }
        
    }

    public void AppleMissed() {
        // Destroy all of the falling Apples

        if (gameOver) {
            return;
        }

        GameObject[] appleArray=GameObject.FindGameObjectsWithTag("Apple");
        foreach ( GameObject tempGO in appleArray ) {
            Destroy( tempGO );
        }

        // Destroy one of the Baskets
        // Get the index of the last Basket in basketList
        int basketIndex = basketList.Count -1;
        // Get a reference to that Basket GameObject
        GameObject basketGO = basketList[basketIndex];
        // Remove the Basket from the list and destroy the GameObject
        basketList.RemoveAt( basketIndex );
        Destroy( basketGO );
        // Increment Round Number
        RoundTracker.INCREMENT_ROUND_COUNTER();

        // If there are no Baskets left, restart the game
        /*
        if ( basketList.Count == 0 ) {
            SceneManager.LoadScene( "_Scene_0" );
        }
        */
        if ( basketList.Count == 0 ) {
            RestartButton.showRestartButton();
            gameOver = true;
            //RestartButton.setActive(true);
        }

    }

    public void BranchHit() {
        foreach ( GameObject tempGO in basketList ) {
            Destroy( tempGO );
            RoundTracker.INCREMENT_ROUND_COUNTER();
        }
        RestartButton.showRestartButton();
        gameOver = true;
    }

    // Update is called once per frame
    
    public void restartLevel() {
        RoundTracker.RESET_ROUND_COUNTER();
        gameOver = false;
        SceneManager.LoadScene( "_Scene_0" );
    }
}
