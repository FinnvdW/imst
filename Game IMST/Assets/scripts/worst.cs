using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worst : MonoBehaviour
{
    void Start()
    {
        
    }

    public void Oppakken(){
    GetComponent<MeshRenderer>().enabled = false;
    GetComponent<BoxCollider>().enabled = false;
    }
}
