using System;
using UnityEngine;

public class PlayerController : Vehicle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     private float horizontalInput;
    private float forwardInput;
    
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //move the player
        // transform.Translate(0,0,1);
         horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Move(forwardInput, horizontalInput);  // Calls the Move() method from Vehicle

    }
}
