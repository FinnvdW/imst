using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurVriezer : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    public AudioClip SchuifOpen;
    public bool SchuifIsOpen;
    public AudioClip SchuifDicht;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        SchuifIsOpen = false;
    }

    public void OpenDeur(){
        if (SchuifIsOpen == false){
            animator.SetTrigger("openschuif");
            audioSource.PlayOneShot(SchuifOpen);
            SchuifIsOpen = true;
        }else{
            animator.SetTrigger("sluitschuif");
            audioSource.PlayOneShot(SchuifDicht);
            SchuifIsOpen = false;
        }
    }
}
