using UnityEngine;

public class PlayerControllerFollower : MonoBehaviour
{
    public Transform cameraTransform; // Drag your camera here in the Inspector
    public float followSpeed = 5f;    // Speed at which the player follows the camera
    public float yMoveSpeed = 2f;     // Speed of the up and down movement on the y-axis
    public float yAmplitude = 0.5f;   // How much the y-axis moves up and down
    public float velocityThreshold = 0.1f; // Minimum velocity to consider the player as moving

    private Rigidbody rb;             // Rigidbody component of the player
    private float originalY;          // Starting position on the y-axis

    void Start()
    {
        // Ensure the camera is set
        if (cameraTransform == null)
        {
            Debug.LogError("CameraTransform is not set! Please drag the camera into the Inspector.");
            return;
        }

        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing from the player!");
        }

        // Store the original y-position
        originalY = transform.position.y;
    }

    void Update()
    {
        // Follow the camera on the x and z axes
        Vector3 targetPosition = new Vector3(cameraTransform.position.x, transform.position.y, cameraTransform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Check the player's velocity
        bool isWalking = rb.velocity.magnitude > velocityThreshold;

        // Move up and down only if the player is moving
        if (isWalking)
        {
            float yOffset = Mathf.Sin(Time.time * yMoveSpeed) * yAmplitude;
            transform.position = new Vector3(transform.position.x, originalY + yOffset, transform.position.z);
        }
        else
        {
            // If not moving, reset to original Y position
            transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
        }
    }
}
