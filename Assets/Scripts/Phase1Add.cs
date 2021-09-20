using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that makes our basic enemies target the player, and thus their parented objects do as well.

public class Phase1Add : MonoBehaviour
{
    // Access to our player object.
    public GameObject player;
    // Thing where we actually find our player object, as well as set some settings for our random bullets.
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
