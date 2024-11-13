using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MaakBurgers : MonoBehaviour
{
    public Speler speler;
    AudioSource audioSource;
    public AudioClip snijden;
    public Image Gordon;
    public AudioClip GordonYap;
    public TextMeshProUGUI GordonTalking;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Burgertjes()
    {
        speler.burgersMaken = true;
        audioSource.PlayOneShot(snijden);
        if (speler.burgersMaken == true){
            audioSource.PlayOneShot(GordonYap);
            GordonTalking.text = "Alright, that's it for today. Time to sleep.";
            GordonTalking.enabled = true;
            StartCoroutine(Tekstweg());
            Gordon.enabled = true;
            StartCoroutine(ImageWeg());
            StartCoroutine(EvenWachten());
        }
    }
    IEnumerator EvenWachten(){
        yield return new WaitForSeconds(3.1f);
        SceneManager.LoadScene("Laatste Scene", LoadSceneMode.Single);
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(3f);
        GordonTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(3f);
        Gordon.enabled = false;
    }
}
