using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LopendeNPCnaarlocatie : MonoBehaviour
{
    // List of target positions the object will move to, in order.
    public Vector3[] targetPositions;

    // Speed at which the object moves (units per second).
    public float moveSpeed = 5f;

    // Rotation speed (degrees per second).
    public float rotationSpeed = 200f;

    // Time after which the object should rotate (in seconds).
    public float rotationDelay = 2f;

    // Track the time elapsed.
    private float timeElapsed = 0f;

    // Index to track the current target position.
    private int currentTargetIndex = 0;

    // To track if the rotation has started.
    private bool hasRotated = false;

    // To track if the rotation is complete.
    private bool isRotating = false;

    // To store the original position of the object.
    private Vector3 originalPosition;

    // A small tolerance for checking if the object has reached a target position
    private float positionTolerance = 0.1f;

    void Start()
    {
        // Store the original position at the start
        originalPosition = transform.position;
    }

    void Update()
    {
        // If no target positions are set, exit.
        if (targetPositions.Length == 0)
            return;

        // If we are not at the last target and not yet back at the original position
        if (currentTargetIndex < targetPositions.Length)
        {
            // Move the object towards the current target position
            transform.position = Vector3.MoveTowards(transform.position, targetPositions[currentTargetIndex], moveSpeed * Time.deltaTime);

            // If the object has reached the target position, handle rotation
            if (!hasRotated && Vector3.Distance(transform.position, targetPositions[currentTargetIndex]) < positionTolerance)
            {
                timeElapsed += Time.deltaTime;

                // If enough time has passed, start rotating the object
                if (timeElapsed >= rotationDelay)
                {
                    RotateObject();
                    hasRotated = true;  // Ensure the rotation only happens once
                    isRotating = true;  // Rotation has started
                }
            }

            // Keep rotating the object if it's still in the rotation process
            if (isRotating)
            {
                RotateObject();
            }

            // If rotation is complete, move to the next target
            if (!isRotating && hasRotated && currentTargetIndex < targetPositions.Length - 1)
            {
                currentTargetIndex++;
                hasRotated = false;  // Reset the rotation flag for the next target
                timeElapsed = 0f;    // Reset the timer for the next move
            }
        }
        else
        {
            // Once all targets are visited, move back to the original position
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, moveSpeed * Time.deltaTime);

            // If the object reaches the original position, reset the cycle
            if (Vector3.Distance(transform.position, originalPosition) < positionTolerance)
            {
                currentTargetIndex = 0;  // Reset to the first target
                hasRotated = false;      // Reset rotation flag for the next cycle
                timeElapsed = 0f;        // Reset the timer
            }
        }
    }

    // Function to rotate the object smoothly
    void RotateObject()
    {
        // Define the target rotation (e.g., rotate 90 degrees on the Y-axis)
        Quaternion targetRotation = Quaternion.Euler(0f, -90f, 0f);

        // Rotate smoothly towards the target rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // Check if the rotation is complete (i.e., has it reached the target rotation?)
        if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
        {
            isRotating = false;  // Stop rotating once the rotation is almost done
            transform.rotation = targetRotation;  // Snap to the exact target rotation
        }
    }
}


