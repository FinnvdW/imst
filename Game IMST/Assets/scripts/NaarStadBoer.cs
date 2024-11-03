using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaarStadBoer : MonoBehaviour
{
    public void NaarStadGaan(){
        SceneManager.LoadScene("stad", LoadSceneMode.Single);
    }
}
