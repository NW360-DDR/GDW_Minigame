using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialize player speed.
    public float PlayerSpeed = 10f;
    // Initialize bullet speed and var for how long it's been since we shot a bullet. Also the reference for the prefab.
    public float BulletRate = 0.25f;
    public float Cooldown;
    public GameObject BulletPrefab;
    // These are needed for movement.
    float XInput;
    float YInput;
    
    // This is to access the TextUpdate script.
    private TextUpdate UI;

    // Start is called before the first frame update
    void Start()
    {
        // Actually nabs the specific object script and writes a test value to the difficulty.
        UI = GameObject.FindObjectOfType<TextUpdate>();
        UI.Write("Diff","LUNATIC");
        // Properly starts up the Cooldown.
        Cooldown = BulletRate;
    }

    // Update is called once per frame
    void Update()
    {
        // Get our axes for movement, and promptly move.
        XInput = Input.GetAxis("Horizontal");
        YInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(XInput, 0, YInput) * Time.deltaTime * PlayerSpeed);
        // Increments the cooldown, done before the bullet check just in case.
        Cooldown += Time.deltaTime;

        // If space is pressed and our Cooldown has ended, spawn a bullet and restart the Cooldown.
        if (Input.GetKey(KeyCode.Space) && Cooldown >= BulletRate)
        {
            Instantiate(BulletPrefab, transform.position, BulletPrefab.transform.rotation);
            Cooldown = 0.0f;
        }
    }
}
