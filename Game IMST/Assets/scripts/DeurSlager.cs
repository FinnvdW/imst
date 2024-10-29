using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurSlager : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    public AudioClip DeurOpen;

    public AudioClip DeurDicht;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OpenDeur(){
        animator.SetTrigger("Openen");
        audioSource.PlayOneShot(DeurOpen);
    }

    public void DichtDeur(){
        animator.SetTrigger("Sluiten");
        audioSource.PlayOneShot(DeurDicht);
    }
}
