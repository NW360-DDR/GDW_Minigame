using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGen : MonoBehaviour
{

    public GameObject Prefab;
    private float Delay = 1.0f;
    public float Repeat = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate",Delay,Repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        Instantiate(Prefab, transform.position, Prefab.transform.rotation);
    }
}
