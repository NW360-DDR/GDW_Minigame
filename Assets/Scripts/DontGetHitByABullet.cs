using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontGetHitByABullet : MonoBehaviour
{
    private int lives = 3;
    public Vector3 StartPos = new Vector3(0,0,-3);

    private TextUpdate UI;

    private void Start()
    {
        UI = GameObject.FindObjectOfType<TextUpdate>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet") || other.CompareTag("Enemy") || other.CompareTag("Boss")){
            lives--;
            UI.Write("Lives", lives);
            transform.position = StartPos;
            // Now to remove every bullet from the screen just so we aren't swarmed at respawning.
            foreach (GameObject bullet in GameObject.FindGameObjectsWithTag("Bullet"))
            {
                Destroy(bullet);
            }
        }
        if (lives == 0)
        {
            UI.GameOver();
            gameObject.SetActive(false);
            foreach (GameObject enemies in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(enemies);
            }
            Destroy(GameObject.FindGameObjectWithTag("Boss"));
        }
    }
}
