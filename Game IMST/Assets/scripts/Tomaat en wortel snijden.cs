using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tomaatenwortelsnijden : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip snijden;
    public Speler speler;
    public Image tomaat;
    public Image wortel;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        wortel.enabled = true;
        tomaat.enabled = true;
    }
    public void Snijden()
    {
        audioSource.PlayOneShot(snijden);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
        wortel.enabled = false;
        tomaat.enabled = false;
    }
}
