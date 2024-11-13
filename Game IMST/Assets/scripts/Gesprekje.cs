using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gesprekje : MonoBehaviour
{
    AudioSource audioSource;
    Animator animator;
    Image image;
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
    public Speler speler;
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();
        ElleTalking.enabled = false;
        Elle.enabled = false;
    }

    void Update(){
        if (speler.worstjeGegeten == true){
            GetComponent<BoxCollider>().enabled = true;
            speler.worstjeGegeten = false;
        }
    }
    void OnTriggerEnter()
    {
        audioSource.PlayOneShot(ElleYap);
        ElleTalking.text = "And? How does it taste?";
        ElleTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Elle.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "Err.. yeah it uh, tastes really nice.";
        StartCoroutine(GordonYapping());
        ElleTalking1.text = "See? I told you so!";
        StartCoroutine(Tekstweg2());
        GordonTalking1.text = "Man.. this stuff is terrible. I'm sure i could make something better-";
        StartCoroutine(GordonYapping2());
        GordonTalking2.text = "I got it! I could mix some vegetables from the greenhouse to my burgers and make it half vegan!";
        StartCoroutine(GordonYapping3());
        GetComponent<BoxCollider>().enabled = false;
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
    }

    IEnumerator GordonYapping3(){
        yield return new WaitForSeconds(16.4f);
        audioSource.PlayOneShot(GordonYap2);
        GordonTalking2.enabled = true;
        yield return new WaitForSeconds(4.5f);
        GordonTalking2.enabled = false;
        Gordon.enabled = false;
    }
}
