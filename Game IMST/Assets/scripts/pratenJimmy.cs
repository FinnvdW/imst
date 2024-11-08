using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pratenJimmy : MonoBehaviour
{
    Animator animator;
    Image image;
    AudioSource audioSource;
    public AudioClip Convo;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI JimmyTalking;
    public Image Jimmy;
    public Image Gordon;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        animator.SetTrigger("praten");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        audioSource.PlayOneShot(Convo);
        JimmyTalking.text = "Hi Gordon! How are you today?";
        JimmyTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Jimmy.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "Good good.. say, did you still have the key to my bike?";
        StartCoroutine(PitYapping());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(3f);
        JimmyTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(3f);
        Jimmy.enabled = false;
    }

    IEnumerator PitYapping(){
        yield return new WaitForSeconds(3.1f);
        GordonTalking.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(5.1f);
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }
}
