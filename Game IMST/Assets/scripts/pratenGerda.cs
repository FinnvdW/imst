using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pratenGerda : MonoBehaviour
{
    Image image;
    AudioSource audioSource;
    public AudioClip GerdaYap;
    public AudioClip GordonYap;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GerdaTalking;
    public Image Gerda;
    public Image Gordon;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    public void Converseren(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        audioSource.PlayOneShot(GerdaYap);
        GerdaTalking.text = "Looking for some vegetables? Feel free to take some carrots and tomatoes if you'd like!";
        GerdaTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Gerda.enabled = true;
        StartCoroutine(ImageWeg());
        GordonTalking.text = "Thanks!";
        StartCoroutine(GordonYapping());
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(4f);
        GerdaTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(4f);
        Gerda.enabled = false;
    }

    IEnumerator GordonYapping(){
        yield return new WaitForSeconds(4.1f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(1.5f);
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }
}
