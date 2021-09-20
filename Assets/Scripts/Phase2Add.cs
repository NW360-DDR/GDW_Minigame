using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that makes our basic enemies target the player, and thus their parented objects do as well.

public class Phase2Add : MonoBehaviour
{

    // Because this enemy only cares about moving back and forth and generating homing Bullets, the only things we need are Speed and a way to tell which way we should be going.
    private bool GoingUp = false;
    private float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Alternating Movement.
        if (GoingUp)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        //When we should alternate.
        if (transform.position.z >= 4.0f)
        {
            GoingUp = false;
        }
        if (transform.position.z <= -4)
        {
            GoingUp = true;
        }
    }
}