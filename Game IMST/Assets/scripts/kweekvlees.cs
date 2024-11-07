using UnityEngine;

public class Kweekvlees : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip interactSound;
    public ObjectiveManager objectiveManager; // Reference to ObjectiveManager

    void Start()
    {
        // Get the AudioSource component attached to this object
        audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        // Play interaction sound if there's an audio source and clip
        if (audioSource != null && interactSound != null)
        {
            audioSource.PlayOneShot(interactSound);
        }

        // Hide the object (make it disappear)
        gameObject.SetActive(false);

        // Notify the objective manager that the objective is complete
        if (objectiveManager != null)
        {
            objectiveManager.OnObjectiveCompleted(); // Progresses to the next objective
        }
    }
}

