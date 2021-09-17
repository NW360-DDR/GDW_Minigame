using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialize player speed.
    private float PlayerSpeed = 5.0f;
    // Initialize bullet speed and var for how long it's been since we shot a bullet. Also the reference for the prefab.
    private float BulletRate = 0.25f;
    private float Cooldown;
    public GameObject BulletPrefab;
    // These are needed for movement.
    float XInput;
    float YInput;
    //These are needed for limiting player movement.
    public float XLim = 4.5f;
    public float ZLim = 4.5f;
    
    // This is to access the TextUpdate script.
    private TextUpdate UI;

    // Start is called before the first frame update
    void Start()
    {
        // Actually nabs the specific object script and writes a test value to the difficulty.
        UI = GameObject.FindObjectOfType<TextUpdate>();
        UI.Write("Phase","PHASE 1");
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
        CheckLocation();
        // Increments the cooldown, done before the bullet check just in case.
        Cooldown += Time.deltaTime;

        // If space is pressed and our Cooldown has ended, spawn a bullet and restart the Cooldown.
        if (Input.GetKey(KeyCode.Space) && Cooldown >= BulletRate)
        {
            Instantiate(BulletPrefab, transform.position, BulletPrefab.transform.rotation);
            Cooldown = 0.0f;
        }
    }

    private void CheckLocation()
    {
        // Checks our X position to make sure it's all good.
        if (transform.position.x > XLim)
        {
            transform.position = new Vector3(XLim, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -XLim)
        {
            transform.position = new Vector3(-XLim, transform.position.y, transform.position.z);
        }
        // Then checks our Z position to make sure that's all good too.
        if (transform.position.z > XLim)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZLim);
        }
        else if (transform.position.z < -ZLim)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -ZLim);
        }
    }
}
