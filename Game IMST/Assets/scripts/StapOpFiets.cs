using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PakFiets : MonoBehaviour
{
    AudioSource opStappen;
    public AudioClip StapOp;
    public bool HeeftFietsSleutel;
    public Speler speler;

    void Start(){
        opStappen = GetComponent<AudioSource>();
    }

    public void StapOpFiets(){
        if(speler.HeeftFietsSleutel == true){
            opStappen.PlayOneShot(StapOp);
            SceneManager.LoadScene("Stad + fiets", LoadSceneMode.Single);
        }
    }
}
