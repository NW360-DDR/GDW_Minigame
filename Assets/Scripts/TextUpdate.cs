using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    // Public variables to access the three Text objects in the scene.
    public Text BossPhase;
    public Text Score;
    public Text Lives;

    // And our score for obvious reasons.
    private int score;
 //THIS IS WHERE THE MAGIC HAPPENS FOLKS
    public void Write(string which, string data)
    {
        // Oi, what exactly are we trying to edit here? Check it out and find out.
        switch (which)
        {
            // Oh, our big bad boss had a phase change? Aight let's let the player know.
            case ("Phase"):
                BossPhase.text = data;
                break;
            // Even better, our player murdered something! Let's take that string and try making it a number to update the score with!
            case ("Score"):
                int number;
                bool gamer = int.TryParse(data, out number);
                if (gamer)
                {
                    score += number;
                    Score.text = "Score: " + score;
                }
                break;
            // Oh no, our player got McMurdered! Sucks to suck.
            case ("Lives"):
                Lives.text = data;
                break;
            // I have zero idea what the fuck I was just given but just in case here's a debug string.
            default:
                Debug.Log("Invalid destination for UIWrite in TextUpdate.cs!");
                break;
        }
    }
}
