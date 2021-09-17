using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*

BulletRandom - A script for the Bullet prefab which is used in MOST enemies. 

By: Nathaniel Owens
*/
public class BulletRandom : MonoBehaviour
{
    // This determines how much variance the prefabricated bullets have.
    private float Variation = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // First the script gets the rotation values in a way we're allowed to mess with
        var euler = transform.eulerAngles;
        // Then we edit the y rotation by our variation in either direction.
        euler.y += (Random.Range(-Variation, Variation));
        //Then we apply our changes.
        transform.eulerAngles = euler;
    }
}
