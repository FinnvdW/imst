using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tomatenPakken : MonoBehaviour
{
    public Image Tomaat;
    void Start()
    {
        Tomaat.enabled = false;
    }

    public void TomatenPakken()
    {
        gameObject.SetActive(false);
        Tomaat.enabled = true;
    }
}
