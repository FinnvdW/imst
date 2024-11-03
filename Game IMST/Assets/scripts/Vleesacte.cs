using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Vleesacte : MonoBehaviour
{
    private AudioSource audioSource;
    public Image image;
    public AudioClip BriefGeluid;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Check if AudioSource is attached to prevent runtime errors
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing on " + gameObject.name);
        }
    }

    public void Lezen()
    {
        // Check if both audioSource and BriefGeluid are assigned before playing the audio
        if (audioSource != null && BriefGeluid != null)
        {
            audioSource.PlayOneShot(BriefGeluid);
        }
        else
        {
            if (BriefGeluid == null)
                Debug.LogWarning("BriefGeluid AudioClip is not assigned in the Inspector!");

            if (audioSource == null)
                Debug.LogWarning("AudioSource component is missing on this GameObject!");
        }

        // Display the image
        if (image != null)
        {
            image.enabled = true;
            StartCoroutine(Imageweg());
        }
        else
        {
            Debug.LogWarning("Image component is not assigned in the Inspector!");
        }
    }

    IEnumerator Imageweg()
    {
        yield return new WaitForSeconds(10);
        if (image != null)
        {
            image.enabled = false;
        }
    }
}

