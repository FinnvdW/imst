using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naarStadNAPolder : MonoBehaviour
{
    void OnTriggerEnter(){
        SceneManager.LoadScene("Stad na Polder met groente", LoadSceneMode.Single);
    }
}
