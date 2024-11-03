using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BriefVader : MonoBehaviour
{
    AudioSource audioSource;
    public Image image;
    public AudioClip BriefGeluid;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Lezen()
    {
        // Check if the AudioClip is assigned before playing it
        if (BriefGeluid != null)
        {
            audioSource.PlayOneShot(BriefGeluid);
        }
        else
        {
            Debug.LogError("BriefGeluid is not assigned in the inspector.");
        }

        image.enabled = true;

        StartCoroutine(Imageweg());
    }

    IEnumerator Imageweg()
    {
        yield return new WaitForSeconds(10);
        image.enabled = false;
    }
}

