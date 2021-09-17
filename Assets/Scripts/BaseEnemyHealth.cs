using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyHealth : MonoBehaviour
{
    // A variable to check if we died by the player's hand.
    private bool byPlayerHand = false;

    // This is to access the TextUpdate script.
    private TextUpdate UI;

    private int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        // Actually nabs the specific object script and writes a test value to the difficulty.
        UI = GameObject.FindObjectOfType<TextUpdate>();
    }

    // Ow, bullets hurt like hell.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            Destroy(other.gameObject);
            HP -= 10;
            
            if (HP <= 0)
            {
                byPlayerHand = true;
                Destroy(gameObject);
            }
        }
    }

    //If it was by the player's hand that this enemy was once again removed of flesh, then reward the player with some points.
    private void OnDestroy()
    {
        if (byPlayerHand)
        {
            UI.Write("Score", "50");
        }
        
    }
}
