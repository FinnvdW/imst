using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tomaatenwortelsnijden : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip snijden;
    public Speler speler;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
    }
    public void Snijden()
    {
        audioSource.PlayOneShot(snijden);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
    }
}
