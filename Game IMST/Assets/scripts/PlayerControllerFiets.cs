using UnityEngine;

public class PlayerControllerFiets : MonoBehaviour // Make sure class name matches the filename
{
    private AudioSource audioSource;           // Audio source to play sound
    public AudioClip moveSound;                // Sound to play when moving
    private Vector3 lastPosition;              // Store last position to detect movement
    public float movementThreshold = 1f;       // Minimum distance required to start the sound

    private bool isMoving = false;             // Track if the player is considered moving

    void Start()
    {
        // Add an AudioSource component if one isn't already attached
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = moveSound;          // Assign sound to AudioSource
        audioSource.loop = true;               // Enable looping for continuous playback while moving

        // Initialize last position
        lastPosition = transform.position;
    }

    void Update()
    {
        // Calculate the distance moved since the last frame
        float distanceMoved = Vector3.Distance(transform.position, lastPosition);

        // Check if the movement threshold is met and set isMoving accordingly
        if (distanceMoved >= movementThreshold)
        {
            isMoving = true;
        }
        else if (distanceMoved < movementThreshold)
        {
            isMoving = false;
        }

        // Start playing the audio if moving, and stop if not
        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }

        // Update last position for the next frame
        lastPosition = transform.position;
    }
}
