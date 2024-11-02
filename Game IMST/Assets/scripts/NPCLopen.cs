using UnityEngine;

public class NPCLopen : MonoBehaviour
{
    public float stepDistance = 1.0f;    // Distance NPC moves each step
    public int stepsPerSide = 10;        // Number of steps the NPC takes on each side of the square
    public float speed = 2.0f;           // Speed of the NPC
    public Animator animator;            // Animator for NPC walking animation

    private int currentStep = 0;         // Current step count on the current side
    private int currentDirection = 0;    // Current direction (0: right, 1: down, 2: left, 3: up)
    private Vector3[] directions = { Vector3.right, Vector3.back, Vector3.left, Vector3.forward };

    void Start()
    {
        // Start the walking animation
        if (animator != null)
        {
            animator.SetBool("walking", true);  // Ensure "walking" is a parameter in Animator
        }
    }

    void Update()
    {
        // Move in the current direction
        Vector3 movement = directions[currentDirection] * speed * Time.deltaTime;
        transform.position += movement;

        // Count steps based on distance covered
        currentStep += Mathf.FloorToInt(movement.magnitude / stepDistance);

        // Check if the NPC has completed the required steps for the current side
        if (currentStep >= stepsPerSide)
        {
            // Reset step count and change direction
            currentStep = 0;
            currentDirection = (currentDirection + 1) % directions.Length;
            // Rotate NPC to face new direction
            transform.rotation = Quaternion.LookRotation(directions[currentDirection]);
        }
    }
}
