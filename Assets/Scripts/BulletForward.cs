using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForward : MonoBehaviour
{

    private float BulletSpeed = 5.0f;
    // Bullet Goes Forward. advanced shit, I know.
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * BulletSpeed);
    }
}
