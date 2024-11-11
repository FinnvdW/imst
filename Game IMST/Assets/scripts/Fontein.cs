using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fontein : MonoBehaviour
{
    
    AudioSource audioSource;

    public AudioClip fontein;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Afspelen(){

        audioSource.PlayOneShot(fontein);
    }


}
