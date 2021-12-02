using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float verticalInput;
    public float horizontalInput;
    public float speed;
    private float turnSpeed = 90;
    private float lap;
    public bool reverse = false;

    public float maxSpeed = 1000.0f;
    public float timeZeroToMax = 10f;
    float accelRatePerSec;
    float forwardVelocity;

    public GameObject brakeLight;

    public bool isSpeed = true;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody>();
        accelRatePerSec = maxSpeed / timeZeroToMax;
        forwardVelocity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.runGame)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                isSpeed = true;
                reverse = false;
                //forwardVelocity = 0;
                brakeLight.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                isSpeed = false;
                brakeLight.SetActive(true);
                reverse = true;
            }

            if (isSpeed == true)
            {
                forwardVelocity += accelRatePerSec * Time.deltaTime;
                forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
                rb.velocity = transform.forward * forwardVelocity;
            }

            if (reverse == true)
            {
                forwardVelocity -= accelRatePerSec * Time.deltaTime;
                forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
                rb.velocity = transform.forward * forwardVelocity;
            }

            horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}
