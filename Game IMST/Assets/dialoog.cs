using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoog : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // Reference to the TextMeshPro component for dialogue
    public TextMeshProUGUI characterNameText; // Reference for displaying character names
    public string[] lines; // Array of dialogue lines (set per NPC)
    public string[] characterNames; // Array of character names corresponding to the dialogue lines
    public float textSpeed; // Speed at which text appears

    private int index; // Current line index

    void Start()
    {
        textComponent.text = string.Empty; // Clear text at start
        characterNameText.text = string.Empty; // Clear character name at start
    }

    // Public method to start dialogue from another script
    public void StartDialogue()
    {
        index = 0; // Reset index
        gameObject.SetActive(true); // Activate the dialogue UI
        StartCoroutine(TypeLine()); // Start typing the first line
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Check for mouse click
        {
            if (textComponent.text == lines[index]) // If the line is fully displayed
            {
                NextLine(); // Go to the next line
            }
            else 
            {
                StopAllCoroutines(); // Stop typing
                textComponent.text = lines[index]; // Display the full line
            }
        }
    }

    IEnumerator TypeLine()
    {
        // Display the character name
        characterNameText.text = characterNames[index];

        // Type each character in the current line
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c; // Append character to text
            yield return new WaitForSeconds(textSpeed); // Wait before next character
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1) // Check if there is a next line
        {
            index++; // Move to the next line
            textComponent.text = string.Empty; // Clear text for next line
            characterNameText.text = string.Empty; // Clear character name for next line
            StartCoroutine(TypeLine()); // Start typing the next line
        }
        else 
        {
            gameObject.SetActive(false); // Hide the dialogue UI if finished
        }
    }
}

