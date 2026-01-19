using UnityEngine;

public class CounterClockwiseRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 30f; // Degrees per second
    public Vector3 rotationAxis = Vector3.up; // Rotate around Y-axis by default
    
    void Update()
    {
        // Rotate the object counter-clockwise around the specified axis
        // Using positive rotation speed for counter-clockwise rotation
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}