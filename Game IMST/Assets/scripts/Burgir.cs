using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burgir : MonoBehaviour
{
    public Speler speler;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (speler.burgersMaken == true){
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
