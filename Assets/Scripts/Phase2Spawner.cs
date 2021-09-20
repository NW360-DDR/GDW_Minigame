using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public BossHealth Boss;
    // This bool exists to make sure we only spawn in the adds once.
    private bool Initialized = true;
    public int[] SpawnLocations;

    // Generate our first phase enemies. Since, you know, we kinda need them.
    void Start()
    {
        Boss = Boss.GetComponent<BossHealth>();
    }

    // Once Phase 2 ends, any enemies that are still around should really be dead. Let's fix that.
    //In that same vein, we shouldn't be doing anything until Phase 1 ends.
    void Update()
    {
        if (Boss.Phase == 1 && Initialized)
        {
            foreach (int meme in SpawnLocations)
            {
                Instantiate(Prefab, new Vector3(meme, 0, 0), Prefab.transform.rotation);
            }
            Initialized = false;
        }
        if (Boss.Phase == 2)
        {
            foreach (GameObject Adds in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(Adds);
            }
            Destroy(gameObject);
        }
    }
}