using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kassa : MonoBehaviour
{
    Animator animator;
    bool isOpen;


    AudioSource audioSource;  // Corrected to AudioSource
    public AudioClip KassaGeluid;  // Ensure this matches in both declaration and use
    
    void Start()
    {
      animator = GetComponent<Animator>();
      isOpen = false;
    }

    public void Openen ()
    {
        if(isOpen == false){
        animator.SetTrigger("open");
        isOpen = true;
        } else {
             animator.SetTrigger("dicht");
             isOpen = false;
        }
    }
}
