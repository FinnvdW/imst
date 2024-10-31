using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaarPolderFiets : MonoBehaviour
{
    void OnTriggerEnter(){
        SceneManager.LoadScene("Polder + Fiets", LoadSceneMode.Single);
    }
}
