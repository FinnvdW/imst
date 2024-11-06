using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kassa : MonoBehaviour
{
    Animator animator;
    bool isOpen;

    AudioSource audioSource;  // Reference to AudioSource
    public AudioClip KassaGeluid;  // Audio clip for the cash register sound

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();  // Assign the AudioSource component
        isOpen = false;
    }

    public void Openen()
    {
        if (isOpen == false)
        {
            animator.SetTrigger("open");
            audioSource.PlayOneShot(KassaGeluid);  // Play sound when opening
            isOpen = true;
        }
        else
        {
            animator.SetTrigger("dicht");
            audioSource.PlayOneShot(KassaGeluid);  // Play sound when closing
            isOpen = false;
        }
    }
}
