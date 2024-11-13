using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeginSpel : MonoBehaviour
{
    Image image;
    AudioSource audioSource;
    public AudioClip GordonYap;
    public AudioClip GordonYap2;
    public AudioClip DeurBel;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public Image Gordon;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.text = "Damn it, I'm almost out of meat, if only the government wasn't this annoying...";
        GordonTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Gordon.enabled = true;
        GordonTalking1.text = "Oh, seems i have a customer.";
        StartCoroutine(ImageWeg());
        StartCoroutine(Tekstweg2());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(4f);
        GordonTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(4f);
    }

    IEnumerator Tekstweg2(){
        yield return new WaitForSeconds(4.1f);
        GordonTalking1.enabled = true;
        audioSource.PlayOneShot(DeurBel);
        audioSource.PlayOneShot(GordonYap2);
        yield return new WaitForSeconds(4f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }
}
