using UnityEngine;

public class InteractiefObject : MonoBehaviour
{
    public MissionManager missionManager; // Referentie naar de MissionManager
    public string missieNaam; // Naam van de missie die gestart moet worden

    private void OnMouseDown()
    {
        // Controleer of de missionManager is ingesteld
        if (missionManager != null)
        {
            missionManager.StartMission(missieNaam);
        }
        else
        {
            Debug.LogWarning("MissionManager is niet ingesteld!");
        }
    }
}
