using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pratenBoer : MonoBehaviour
{
    Animator animator;
    Image image;
    AudioSource audioSource;
    public AudioClip Convo;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public TextMeshProUGUI GordonTalking2;
    public TextMeshProUGUI BoerTalking;
    public TextMeshProUGUI BoerTalking1;
    public TextMeshProUGUI BoerTalking2;
    public Image Boer;
    public Image Gordon;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        GordonTalking1.enabled = false;
        GordonTalking2.enabled = false;
        BoerTalking1.enabled = false;
        BoerTalking2.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        animator.SetTrigger("praten");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
    }
}
