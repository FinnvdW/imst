using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeurSlager2 : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    public AudioClip DeurOpen;
    public bool DeurIsOpen;
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
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(ColliderTerug());
        }else{
            animator.SetTrigger("sluiten");
            audioSource.PlayOneShot(DeurDicht);
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().enabled = true;
            DeurIsOpen = false;
        }
    }

    IEnumerator ColliderTerug(){
        yield return new WaitForSeconds(2f);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
    }

    IEnumerator DeurOpenen(){
        yield return new WaitForSeconds(0.1f);
        animator.SetTrigger("openen");
    }

}
