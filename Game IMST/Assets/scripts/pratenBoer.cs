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
    public AudioClip BoerYap;
    public AudioClip GordonYap;
    public AudioClip BoerYap2;
    public AudioClip GordonYap2;
    public AudioClip BoerYap3;
    public AudioClip BoerYap4;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public TextMeshProUGUI GordonTalking2;
    public TextMeshProUGUI BoerTalking;
    public TextMeshProUGUI BoerTalking1;
    public TextMeshProUGUI BoerTalking2;
    public TextMeshProUGUI BoerTalking3;
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
        BoerTalking3.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        animator.SetTrigger("praten");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        audioSource.PlayOneShot(BoerYap);
        BoerTalking.text = "Gordon? I didn't expect to see you here! What can I do for ya?";
        BoerTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Boer.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "Hello Harm, I'll cut to the chase. I saw the carcass of one of your animals earlier, any chance I could buy that from you?";
        StartCoroutine(GordonYapping());
        BoerTalking1.text = "Hmm, sure I guess, what would ya be usin' it for tho?";
        StartCoroutine(Tekstweg2());
        GordonTalking1.text = "Well, you see, I've sold my very last piece of meat. I needed more, which gave me the idea to pay you a visit my friend.";
        StartCoroutine(GordonYapping2());
        BoerTalking2.text = "I see. I'd be willin' to sell it to ya, but I wanna see a good price for it. Whatcha think of 50 euros for a kilo?";
        StartCoroutine(Tekstweg3());
        GordonTalking2.text = "That's fine, deal.";
        StartCoroutine(GordonYapping3());
        BoerTalking3.text = "Pleasure doin' business with ya! I'll give it to ya right away.";
        StartCoroutine(Tekstweg4());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(3f);
        BoerTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(3f);
        Boer.enabled = false;
    }

    IEnumerator GordonYapping(){
        yield return new WaitForSeconds(3.1f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(4.5f);
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg2(){
        yield return new WaitForSeconds(7.7f);
        audioSource.PlayOneShot(BoerYap2);
        BoerTalking1.enabled = true;
        Boer.enabled = true;
        yield return new WaitForSeconds(5f);
        BoerTalking1.enabled = false;
        Boer.enabled = false;
    }

    IEnumerator GordonYapping2(){
        yield return new WaitForSeconds(12.8f);
        audioSource.PlayOneShot(GordonYap2);
        GordonTalking1.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(5f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg3(){
        yield return new WaitForSeconds(17.9f);
        audioSource.PlayOneShot(BoerYap3);
        BoerTalking2.enabled = true;
        Boer.enabled = true;
        yield return new WaitForSeconds(5f);
        BoerTalking2.enabled = false;
        Boer.enabled = false;
    }

    IEnumerator GordonYapping3(){
        yield return new WaitForSeconds(22.9f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking2.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(3f);
        GordonTalking2.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator Tekstweg4(){
        yield return new WaitForSeconds(25.9f);
        audioSource.PlayOneShot(BoerYap4);
        BoerTalking3.enabled = true;
        Boer.enabled = true;
        yield return new WaitForSeconds(4.5f);
        BoerTalking3.enabled = false;
        Boer.enabled = false;
    }
}
