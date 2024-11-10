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
    public AudioClip JimmyYap;
    public AudioClip GordonYap;
    public AudioClip JimmyYap2;
    public AudioClip GordonYap2;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public TextMeshProUGUI GordonTalking2;
    public TextMeshProUGUI JimmyTalking;
    public TextMeshProUGUI JimmyTalking1;
    public TextMeshProUGUI JimmyTalking2;
    public Image Jimmy;
    public Image Gordon;

    void Start(){
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        GordonTalking1.enabled = false;
        GordonTalking2.enabled = false;
        JimmyTalking1.enabled = false;
        JimmyTalking2.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        animator.SetTrigger("praten");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        audioSource.PlayOneShot(JimmyYap);
        JimmyTalking.text = "Hi Gordon! How are you today?";
        JimmyTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Jimmy.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "Good good.. say, did you still have the key to my bike?";
        StartCoroutine(GordonYapping());
        JimmyTalking1.text = "Oh! Yes of course, I put it right next to me since I wanted to pay you a visit today.";
        StartCoroutine(Tekstweg2());
        GordonTalking1.text = "Thanks, that's great. Your shop seems to be doing good by the way, yet that stupid fake meat is doing even better it seems.";
        StartCoroutine(GordonYapping2());
        JimmyTalking2.text = "Yeah. I'm happy with how it's going here, but nothing can BEATLE that shop. Get it, beat-le-?";
        StartCoroutine(Tekstweg3());
        GordonTalking2.text = "Yeah yeah very funny, guess I'll need to visit that dumb place sometime. Thanks for the key Jimmy.";
        StartCoroutine(GordonYapping3());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(3f);
        JimmyTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(3f);
        Jimmy.enabled = false;
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
        audioSource.PlayOneShot(JimmyYap2);
        JimmyTalking1.enabled = true;
        Jimmy.enabled = true;
        yield return new WaitForSeconds(4.5f);
        JimmyTalking1.enabled = false;
        Jimmy.enabled = false;
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
        audioSource.PlayOneShot(JimmyYap2);
        JimmyTalking2.enabled = true;
        Jimmy.enabled = true;
        yield return new WaitForSeconds(4.5f);
        JimmyTalking2.enabled = false;
        Jimmy.enabled = false;
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
}
