using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fietssleutel : MonoBehaviour
{
    AudioSource audioSource;  // Corrected to AudioSource
    public AudioClip Sleuteloppakgeluidje;  // Ensure this matches in both declaration and use
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Oppakken()
    {
        audioSource.PlayOneShot(Sleuteloppakgeluidje);  // Corrected variable name here
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}
