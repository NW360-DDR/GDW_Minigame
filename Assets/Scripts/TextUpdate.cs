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
    public void Write(string which, int data)
    {
        // Oi, what exactly are we trying to edit here? Check it out and find out.
        switch (which)
        {
            // Oh, our big bad boss had a phase change? Aight let's let the player know.
            case ("Phase"):
                BossPhase.text ="Phase " + data;
                break;
            // Even better, our player murdered something! Let's take that string and try making it a number to update the score with!
            case ("Score"):
                score += data;
                Score.text = "Score: " + score;
                break;
            // Oh no, our player got McMurdered! Sucks to suck.
            case ("Lives"):
                Lives.text = "Lives: " + data;
                break;
            // I have zero idea what the fuck I was just given but just in case here's a debug string.
            default:
                Debug.Log("Invalid destination for UIWrite in TextUpdate.cs!");
                break;
        }
    }
    //This script exists solely to handle when we run out of lives.
    public void GameOver()
    {
        BossPhase.gameObject.transform.position = new Vector3 (Screen.width * 0.5f, Screen.height * 0.4f, 0);
        BossPhase.text = "Game Over!";
        Score.gameObject.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.35f, 0);
        Score.fontSize = 48;
        Lives.gameObject.SetActive(false);
    }

    public void Winner()
    {
        BossPhase.gameObject.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.4f, 0);
        BossPhase.text = "You Win!";
        Score.gameObject.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.35f, 0);
        Score.fontSize = 48;
        Lives.gameObject.SetActive(false);
    }
}
