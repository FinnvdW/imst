using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Kweekvlees : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip interactSound;
    public ObjectiveManager objectiveManager; // Reference to ObjectiveManager
    public Speler speler;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        speler.worstjeGegeten = true;
        // Play interaction sound if there's an audio source and clip
        if (audioSource != null && interactSound != null)
        {
            audioSource.PlayOneShot(interactSound);
        }

        // Hide the object (make it disappear)
        gameObject.SetActive(false);
        

    }

    
}

