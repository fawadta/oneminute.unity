using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;  // Controls the speed of the oscillation
    public float rotationAmount = 15.0f;  // Controls the degree of rotation to each side

    private float elapsedTime = 0.0f;  // Tracks the elapsed time

    void Update()
    {
        // Update the elapsed time
        elapsedTime += Time.deltaTime * rotationSpeed;

        // Calculate the rotation angle using Mathf.Sin
        float angle = Mathf.Sin(elapsedTime) * rotationAmount;

        // Set the rotation of the player. Assuming you're rotating around the Y axis.
        transform.rotation = Quaternion.Euler(0, 180 + angle, 0);
    }
}
