using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float XMin;
    public float XMax;
    public float ZMin = -5.1f;
    public float ZMax = 5.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//           Are we within the Z boundary?                        OR  Are we within the X boundary?
        if ((transform.position.z > ZMax | transform.position.z < ZMin) | ((transform.position.x > XMax | transform.position.x < XMin)))
        {
            Destroy(gameObject);
        }
    }
}
