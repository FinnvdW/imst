using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naarStadNAPolder : MonoBehaviour
{
    public void NaarStadGaan(){
        SceneManager.LoadScene("Stad na Polder met groente", LoadSceneMode.Single);
    }
}
