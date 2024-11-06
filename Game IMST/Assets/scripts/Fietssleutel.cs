using UnityEngine;

public class Fietssleutel : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip Sleuteloppakgeluidje;
    public Speler speler;
    public ObjectiveManager objectiveManager;  // Reference to ObjectiveManager

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Oppakken()
    {
        // Play pickup sound and hide the key
        audioSource.PlayOneShot(Sleuteloppakgeluidje);
        speler.HeeftFietsSleutel = true;
        gameObject.SetActive(false);

        // Notify ObjectiveManager that the objective is completed
        if (objectiveManager != null)
        {
            objectiveManager.OnObjectiveCompleted();
        }
        else
        {
            Debug.LogWarning("ObjectiveManager reference not set in Fietssleutel.");
        }
    }
}
