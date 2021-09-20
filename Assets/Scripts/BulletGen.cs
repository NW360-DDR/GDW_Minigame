using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that generates bullets after x seconds have passed, generating them every y seconds.
//The bullet type can be determined in the Inspector tab for the attached prefab.


public class BulletGen : MonoBehaviour
{
     
    //Determines the bullet we generate, determined by me, the developer in the Inspector.
    public GameObject Prefab;
    //Variables needed for InvokeRepeating
    private float Delay = 1.0f;
    public float Repeat = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate",Delay,Repeat);
    }

    void Generate()
    {
        Instantiate(Prefab, transform.position, transform.rotation);
    }
    public void Settings(float delay, float repeat)
    {
        Delay = delay;
        Repeat = repeat;
    }
}
