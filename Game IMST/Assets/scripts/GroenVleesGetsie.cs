using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroenVleesGetsie : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip snijden;
    public Speler speler;
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
        speler.heeftVleesOpgehangen = true;
    }
}
