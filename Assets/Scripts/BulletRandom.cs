using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var euler = transform.eulerAngles;
        euler.y = 180;
        euler.y += Random.Range(-10.0f, 10.0f);
        transform.eulerAngles = euler;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
