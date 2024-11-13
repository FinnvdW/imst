using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LaatsteScene : MonoBehaviour
{
    public Image Gordon;
    AudioSource audioSource;
    public AudioClip GordonYap;
    public TextMeshProUGUI GordonTalking;
    public Speler speler;
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (speler.burgersMaken == true){
            GetComponent<BoxCollider>().enabled = true;
            audioSource.PlayOneShot(GordonYap);
            GordonTalking.text = "Alright, that's it for today. Time to sleep.";
            GordonTalking.enabled = true;
            StartCoroutine(Tekstweg());
            Gordon.enabled = true;
            StartCoroutine(ImageWeg());
            StartCoroutine(EvenWachten());
            SceneManager.LoadScene("LaatsteScene", LoadSceneMode.Single);
        }
    }

    IEnumerator EvenWachten(){
        yield return new WaitForSeconds(3.1f);
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
