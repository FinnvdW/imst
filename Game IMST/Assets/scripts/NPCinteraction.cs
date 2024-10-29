using UnityEngine;

public class NPCinteraction : MonoBehaviour
{
    public Dialoog dialoog; // Reference to the Dialoog component

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player entered the trigger
        {
            dialoog.StartDialogue(); // Start the dialogue
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player exited the trigger
        {
            dialoog.gameObject.SetActive(false); // Optionally hide the dialogue UI
        }
    }
}
