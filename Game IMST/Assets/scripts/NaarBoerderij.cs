using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaarBoerderij : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(){
        SceneManager.LoadScene("Boerderij", LoadSceneMode.Single);
    }
}
