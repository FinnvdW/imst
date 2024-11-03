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
            Debug.LogError($"AudioSource component is missing on {gameObject.name}. Please add one.");
        }
    }

    public void Lezen()
    {
        // Ensure audioSource and BriefGeluid are assigned before playing the audio
        if (audioSource != null)
        {
            if (BriefGeluid != null)
            {
                audioSource.PlayOneShot(BriefGeluid);
            }
            else
            {
                Debug.LogWarning("BriefGeluid AudioClip is not assigned in the Inspector!");
            }
        }
        else
        {
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

    private IEnumerator Imageweg()
    {
        yield return new WaitForSeconds(10);
        if (image != null)
        {
            image.enabled = false;
        }
    }
}

