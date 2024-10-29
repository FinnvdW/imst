using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public Objective[] objectives; // Array van doelstellingen

    private void Start()
    {
        foreach (var objective in objectives)
        {
            objective.isCompleted = false; // Stel alle doelstellingen in als niet voltooid
        }
    }

    public void StartMission(string missieNaam)
    {
        Debug.Log("Nieuwe missie gestart: " + missieNaam);
        // Hier kun je logica toevoegen om doelstellingen in te stellen
    }

    public void TriggerObjectiveCompletion(int index)
    {
        if (index >= 0 && index < objectives.Length)
        {
            objectives[index].isCompleted = true; // Markeer de objective als voltooid
            Debug.Log("Objective " + index + " voltooid!");
        }
        else
        {
            Debug.LogWarning("Objective index buiten bereik: " + index);
        }
    }
}

[System.Serializable]
public class Objective
{
    public string objectiveName; // Naam van de doelstelling
    public bool isCompleted; // Is de doelstelling voltooid?
}
