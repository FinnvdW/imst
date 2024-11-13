using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TerugVanBoer : MonoBehaviour
{
    Image image;
    AudioSource audioSource;
    public AudioClip GordonYap;
    public AudioClip GordonYap2;
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
        GordonTalking.text = "Hm, now that i look at it, this meat does look a little bit suspicious...";
        GordonTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Gordon.enabled = true;
        GordonTalking1.text = "Maybe I shouldn't sell it.";
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
        audioSource.PlayOneShot(GordonYap2);
        yield return new WaitForSeconds(3f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }
}
