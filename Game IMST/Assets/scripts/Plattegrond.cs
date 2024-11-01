using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plattegrond : MonoBehaviour
{

   public Image image;

    void Start()
    {
        
    }
    public void Lezen(){

        image.enabled = true;

        StartCoroutine(Imageweg());
    }
    IEnumerator Imageweg(){
        yield return new WaitForSeconds(5);
        image.enabled = false;
     }
}
