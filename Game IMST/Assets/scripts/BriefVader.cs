using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BriefVader : MonoBehaviour
{
   AudioSource audioSource;
   public Image image;

   public AudioClip BriefGeluid;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
        public void Lezen(){
            audioSource.PlayOneShot(BriefGeluid);

            image.enabled = true;

            StartCoroutine(Imageweg());
        }
        IEnumerator Imageweg(){
            yield return new WaitForSeconds(10);
            image.enabled = false;
        }
}
