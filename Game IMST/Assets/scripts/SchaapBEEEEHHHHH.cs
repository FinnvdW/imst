using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchaapBEEEEHHHHH : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip BEEEHHHH;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(){
        audioSource.PlayOneShot(BEEEHHHH);
        StartCoroutine(BEEHHHHAlweer());
        audioSource.PlayOneShot(BEEEHHHH);
    }

    IEnumerator BEEHHHHAlweer(){
        yield return new WaitForSeconds(7f);
    }
}
