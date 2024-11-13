using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pratenElle : MonoBehaviour
{
    Animator animator;
    Image image;
    AudioSource audioSource;
    public AudioClip ElleYap;
    public AudioClip GordonYap;
    public AudioClip ElleYap2;
    public AudioClip GordonYap2;
    public AudioClip ElleYap3;
    public AudioClip ElleYap4;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public TextMeshProUGUI GordonTalking2;
    public TextMeshProUGUI ElleTalking;
    public TextMeshProUGUI ElleTalking1;
    public TextMeshProUGUI ElleTalking2;
    public TextMeshProUGUI ElleTalking3;
    public Image Elle;
    public Image Gordon;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        GordonTalking1.enabled = false;
        GordonTalking2.enabled = false;
        ElleTalking1.enabled = false;
        ElleTalking2.enabled = false;
        ElleTalking3.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        animator.SetTrigger("praten");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        audioSource.PlayOneShot(ElleYap);
        ElleTalking.text = "What can I do for you?";
        ElleTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Elle.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "What is this bullshit meat nonsense about?";
        StartCoroutine(GordonYapping());
        ElleTalking1.text = "Bullshit? I assure you it's not bullshit.";
        StartCoroutine(Tekstweg2());
        GordonTalking1.text = "I.. I'm sorry. I meant to ask where I could try a sample.";
        StartCoroutine(GordonYapping2());
        ElleTalking2.text = "Alright.. well behind you is a plate with our finest Labo meat. Give it a try!";
        StartCoroutine(Tekstweg3());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(3f);
        ElleTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(3f);
        Elle.enabled = false;
    }

    IEnumerator GordonYapping(){
        yield return new WaitForSeconds(3.1f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(3.5f);
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg2(){
        yield return new WaitForSeconds(6.7f);
        audioSource.PlayOneShot(ElleYap2);
        ElleTalking1.enabled = true;
        Elle.enabled = true;
        yield return new WaitForSeconds(4.5f);
        ElleTalking1.enabled = false;
        Elle.enabled = false;
    }

    IEnumerator GordonYapping2(){
        yield return new WaitForSeconds(11.3f);
        audioSource.PlayOneShot(GordonYap2);
        GordonTalking1.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(5f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg3(){
        yield return new WaitForSeconds(16.4f);
        audioSource.PlayOneShot(ElleYap3);
        ElleTalking2.enabled = true;
        Elle.enabled = true;
        yield return new WaitForSeconds(4.5f);
        ElleTalking2.enabled = false;
        Elle.enabled = false;
    }

    IEnumerator GordonYapping3(){
        yield return new WaitForSeconds(21f);
        audioSource.PlayOneShot(GordonYap2);
        GordonTalking2.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(4.5f);
        GordonTalking2.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg4(){
        yield return new WaitForSeconds(25.5f);
        audioSource.PlayOneShot(ElleYap4);
        ElleTalking3.enabled = true;
        Elle.enabled = true;
        yield return new WaitForSeconds(4.5f);
        ElleTalking3.enabled = false;
        Elle.enabled = false;
    }
}
