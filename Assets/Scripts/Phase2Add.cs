using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that makes our basic enemies target the player, and thus their parented objects do as well.

public class Phase2Add : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
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
