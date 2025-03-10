using UnityEngine;

public class AIVehicle : Vehicle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Move(float forwardInput, float horizontalInput)
    {
        // AI movement logic (e.g., follow waypoints)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
