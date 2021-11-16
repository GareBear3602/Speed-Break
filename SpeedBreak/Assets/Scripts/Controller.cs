using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float verticalInput;
    public float horizontalInput;
    public float speed;
    private float turnSpeed = 90;

    public float maxSpeed = 1000.0f;
    public float timeZeroToMax = 10f;
    float accelRatePerSec;
    float forwardVelocity;

    public bool isSpeed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        accelRatePerSec = maxSpeed / timeZeroToMax;
        forwardVelocity = 0f;
        isSpeed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isSpeed = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            isSpeed = false;
        }

        if (isSpeed == true)
        {
            forwardVelocity += accelRatePerSec * Time.deltaTime;
            forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
            rb.velocity = transform.forward * forwardVelocity;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
