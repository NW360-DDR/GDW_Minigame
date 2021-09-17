using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBullet : MonoBehaviour
{

    private GameObject player;
    private float speed = 3.0f;
    // How long does our bullet continue to hunt the player?
    public float HomingTime = 1.5f;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (HomingTime > 0)
        {
            transform.LookAt(player.transform.position);
            HomingTime -= Time.deltaTime;
        }
        else if (speed < 7.0f)
        {
            speed += Time.deltaTime * 5; 
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
