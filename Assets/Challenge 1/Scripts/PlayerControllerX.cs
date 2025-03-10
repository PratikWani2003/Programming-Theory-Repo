using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed =10.0f;
    public float rotationSpeed = 100.0f;
    // public float verticalInput;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // rotationSpeed  = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward * horizontalInput );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
