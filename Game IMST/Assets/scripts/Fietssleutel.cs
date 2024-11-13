using UnityEngine;

public class Fietssleutel : MonoBehaviour
{
    AudioSource sleutelPakken;
    public AudioClip Sleutel;
    public Speler speler;
    public ObjectiveManager objectiveManager;  // Reference to ObjectiveManager

    void Start()
    {
        sleutelPakken = GetComponent<AudioSource>();
    }

    public void Oppakken()
    {
        speler.HeeftFietsSleutel = true;
        gameObject.SetActive(false);
        sleutelPakken.PlayOneShot(Sleutel);

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
