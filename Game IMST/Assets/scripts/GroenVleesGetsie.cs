using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroenVleesGetsie : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip snijden;
    public Speler speler;
    public Image Meat;
    public Image Inventory;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        Meat.enabled = true;
        Inventory.enabled = true;
    }

    // Update is called once per frame
    public void Snijden()
    {
        audioSource.PlayOneShot(snijden);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
        speler.heeftVleesOpgehangen = true;
        Meat.enabled = false;
    }
}
