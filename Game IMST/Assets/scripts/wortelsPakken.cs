using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wortelsPakken : MonoBehaviour
{
    public Image wortel;
    void Start()
    {
        wortel.enabled = false;
    }

    public void WortelsPakken()
    {
        gameObject.SetActive(false);
        wortel.enabled = true;
    }
}
