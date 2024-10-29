using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurSlager : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    public AudioClip DeurOpen;
    public bool DeurIsOpen;
    public bool DeurIsDicht;

    public AudioClip DeurDicht;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        DeurIsOpen = false;
    }

    public void OpenDeur(){
        if (DeurIsOpen == false){
            animator.SetTrigger("openen");
            audioSource.PlayOneShot(DeurOpen);
            DeurIsOpen = true;
        }
        
        if (DeurIsOpen == true){
            animator.SetTrigger("sluiten");
            audioSource.PlayOneShot(DeurDicht);
            DeurIsOpen = false;
        }
    }

}
