using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    public int objectiveIndex; // Index van de objective die deze trigger moet voltooien
    private MissionManager missionManager; // Referentie naar de MissionManager

    void Start()
    {
        // Zoek de MissionManager in de scène
        missionManager = FindObjectOfType<MissionManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Controleer of de speler de trigger aanraakt
        {
            missionManager.TriggerObjectiveCompletion(objectiveIndex); // Voltooi de objective
            Destroy(gameObject); // Verwijder de trigger na gebruik
        }
    }
}
