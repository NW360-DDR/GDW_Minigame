using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{

    public Text Diff;
    public Text Score;
    public Text Lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Write(string which, string data)
    {
        switch (which)
        {
            case ("Diff"):
                Diff.text = data;
                break;
            case ("Score"):
                Score.text = data;
                break;
            case ("Lives"):
                Lives.text = data;
                break;
            default:
                Debug.Log("Invalid destination for UIWrite in TextUpdate.cs!");
                break;
        }
    }
}
