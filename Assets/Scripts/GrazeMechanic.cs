using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GrazeMechanic, a script for EnemyBullets that detects when the bullet has left the GrazeHitbox for the first time to add graze points. 
// If the bullet enters the GrazeHitbox and leaves for a second time, no points will be added.


public class GrazeMechanic : MonoBehaviour
{
    // Private object to use the score updater.
    private TextUpdate UI;
    // Bool to tell us we have not grazed before.
    private bool NotGrazed = true;

    void Start()
    {
        // Finds the score Updater so we don't need to run around like a headless chicken finding it.
        UI = GameObject.FindObjectOfType<TextUpdate>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Graze") && NotGrazed){

            UI.Write("Score", 10);
            NotGrazed = false;
        }
    }
}
