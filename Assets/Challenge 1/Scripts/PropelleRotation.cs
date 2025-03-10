using UnityEngine;

public class PropelleRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 500.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward* rotationSpeed* Time.deltaTime);
    }
}
