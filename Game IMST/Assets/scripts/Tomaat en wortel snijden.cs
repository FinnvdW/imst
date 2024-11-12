using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomaatenwortelsnijden : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    public void Snijden()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
}
