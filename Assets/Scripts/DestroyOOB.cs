using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A script applied to all Bullet prefabs to make sure we don't go and clog up the RAM of poor Timmy's 12 year old stone age computer.
public class DestroyOOB : MonoBehaviour
{
    public float XMin = -5;
    public float XMax = 5;
    public float ZMin = -5;
    public float ZMax = 5;

    // Update is called once per frame
    void Update()
    {//           Are we within the Z boundary?                        OR  Are we within the X boundary?
        if ((transform.position.z > ZMax | transform.position.z < ZMin) | ((transform.position.x > XMax | transform.position.x < XMin)))
        {
            Destroy(gameObject);
        }
    }
}