using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase1Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public BossHealthScript Boss;

    public int[] SpawnLocations;

    // Generate our first phase enemies. Since, you know, we kinda need them.
    void Start()
    {
        Boss = Boss.GetComponent<BossHealthScript>();
        Debug.Log(Boss.Phase);
        foreach(int meme in SpawnLocations)
        {
            Instantiate(Prefab, new Vector3(meme, 0, 4), Prefab.transform.rotation);
        }
        
    }

    // Once Phase 1 ends, any enemies that are still around should really be dead. Let's fix that.
    void Update()
    {
        if (Boss.Phase == 1)
        {
            foreach (GameObject Adds in GameObject.FindGameObjectsWithTag("Add"))
            {
                Destroy(Adds);
            }
            Destroy(gameObject);
        }
    }
}
