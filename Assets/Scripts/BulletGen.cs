using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that generates bullets after x seconds have passed, generating them every y seconds


public class BulletGen : MonoBehaviour
{

    public GameObject Prefab;
    private float Delay = 1.0f;
    public float Repeat = 0.25f;
    public int Difficulty = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate",Delay,Repeat);
    }

    void Generate()
    {
        for (int i = 0; i < Difficulty; i++)
        {
            Instantiate(Prefab, transform.position, transform.rotation);
        }
        
    }
}
