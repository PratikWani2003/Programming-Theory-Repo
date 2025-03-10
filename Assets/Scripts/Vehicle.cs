using UnityEngine;

// Base class for all vehicles
public class Vehicle : MonoBehaviour
{
     protected float speed = 20.0f;  // Encapsulated variable
    private float turnSpeed = 45.0f;

    public float Speed  // Public property with getter and setter
    {
        get { return speed; }
        set 
        {
            if (value > 0)  // Ensure speed is always positive
                speed = value;
        }
    }

    public virtual void Move(float forwardInput, float horizontalInput)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
