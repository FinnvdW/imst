using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burgir1 : MonoBehaviour
{
    AudioSource audioSource;
    public Speler speler;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speler.burgersMaken == true){
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
