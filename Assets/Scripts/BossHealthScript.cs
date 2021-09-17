using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthScript : MonoBehaviour
{
    // Array of boss health phases. Good for making multiple parts of a boss fight.
    public int[] HP;
    public Slider HealthBar;
    // Variable to keep track of the current phase.
    public int Phase = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Starts our Health Bar off properly by scaling the values to the first phase health.
        HealthBar = HealthBar.GetComponent<Slider>();
        HealthBar.maxValue = HP[Phase];
        HealthBar.value = HP[Phase];
    }

    // Update is called once per frame
    void Update()
    {
        // If the current phase is dead, try to update the Phase.
        if(HP[Phase] <= 0)
        {
            UpdateBossPhase();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            Destroy(other.gameObject);
            HP[Phase] -= 10;
            HealthBar.value = HP[Phase];
        }
    }


    private void UpdateBossPhase()
    {
        // Increment the Phase, then if we've run out of phases, die and take the Boss Health bar with us.
        Phase++;
        if (Phase == HP.Length)
        {
            Destroy(gameObject);
            Destroy(GameObject.Find("BossHealth"));
        }
        // If that still wasn't our final form, though, update the Health bar with the new maxHealth value. Sorry Frieza.
        else
        {
            HealthBar.maxValue = HP[Phase];
            HealthBar.value = HP[Phase];
        }
    }
}
