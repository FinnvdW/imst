using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PakFiets : MonoBehaviour
{
    AudioSource opStappen;
    public AudioClip StapOp;

    void Start(){
        opStappen = GetComponent<AudioSource>();
    }

    public void StapOpFiets(){
        opStappen.PlayOneShot(StapOp);
        SceneManager.LoadScene("Stad + fiets", LoadSceneMode.Single);
    }
}
