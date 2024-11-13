using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaarPolderZonderFiets : MonoBehaviour
{
    void OnTriggerEnter(){
        SceneManager.LoadScene("Polder no fiets", LoadSceneMode.Single);
    }
}
