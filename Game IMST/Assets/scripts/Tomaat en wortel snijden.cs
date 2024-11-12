using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomaatenwortelsnijden : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip snijden;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Snijden()
    {
        audioSource.PlayOneShot(snijden);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
    }
}
