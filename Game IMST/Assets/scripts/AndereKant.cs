using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AndereKant : MonoBehaviour
{
    Image image;
    AudioSource audioSource;
    public AudioClip GordonYap;
    public AudioClip GordonYap2;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public Image Gordon;
    public Speler speler;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }
    public void OnTriggerEnter()
    {
        if (speler.HeeftFietsSleutel == true){
            audioSource.PlayOneShot(GordonYap);
            GordonTalking.text = "I shouldn't go this way, I need to go to the farm.";
            GordonTalking.enabled = true;
            StartCoroutine(Tekstweg());
            Gordon.enabled = true;
            GordonTalking1.text = "Maybe I should check the map.";
            StartCoroutine(ImageWeg());
            StartCoroutine(Tekstweg2());
        }else{
            audioSource.PlayOneShot(GordonYap);
            GordonTalking.text = "I shouldn't go this way, I need to go to Jimmy.";
            GordonTalking.enabled = true;
            StartCoroutine(Tekstweg());
            Gordon.enabled = true;
            GordonTalking1.text = "Maybe I should check the map.";
            StartCoroutine(ImageWeg());
            StartCoroutine(Tekstweg2());
        }
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
