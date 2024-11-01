using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaarStad : MonoBehaviour
{
    void OnTriggerEnter(){
        SceneManager.LoadScene("stad", LoadSceneMode.Single);
    }
}
