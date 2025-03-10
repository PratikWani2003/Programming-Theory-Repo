using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public const float speed = 20.0f;
    [SerializeField]  float turnSpeed =45.0f;
    [SerializeField]  float horizontalInput ;
    [SerializeField]  float forwardInput;
    
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //move the player
        // transform.Translate(0,0,1);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput *Time.deltaTime);

    }
}
