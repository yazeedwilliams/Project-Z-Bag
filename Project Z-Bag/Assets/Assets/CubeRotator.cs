using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 30f; // Degrees per second
    public Vector3 rotationAxis = Vector3.up; // Rotate around Y-axis by default
    
    void Update()
    {
        // Rotate the object clockwise around the specified axis
        // Using negative rotation speed for clockwise rotation
        transform.Rotate(rotationAxis * -rotationSpeed * Time.deltaTime);
    }
}