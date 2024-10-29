using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialoog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    void Start(){
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void StartDialogue()
    {
    index = 0;
    StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine(){
    //type each character
    foreach (char c in lines[index].ToCharArray())
    {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
    }

    }


}
