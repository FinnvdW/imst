using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ObjectiveManager : MonoBehaviour
{
    public List<Objective> objectives; // Lijst met objectives
    public TextMeshProUGUI objectiveText;         // UI-tekst om huidige objective te tonen
    public TextMeshProUGUI completionText;        // UI-tekst om voltooiing te tonen

    private int currentObjectiveIndex = 0; // Bijhouden welk objective actief is

    void Start()
    {
        UpdateObjectiveText();
        completionText.enabled = false;
    }

    public void AddProgressToObjective(int count = 1)
    {
        if (currentObjectiveIndex < objectives.Count)
        {
            Objective currentObjective = objectives[currentObjectiveIndex];
            currentObjective.AddProgress(count);
            UpdateObjectiveText();

            if (currentObjective.IsCompleted)
            {
                CompleteObjective();
            }
        }
    }

    private void UpdateObjectiveText()
    {
        if (currentObjectiveIndex < objectives.Count)
        {
            Objective currentObjective = objectives[currentObjectiveIndex];
            objectiveText.text = currentObjective.GetProgressText();
        }
        else
        {
            objectiveText.text = "Alle objectives voltooid!";
        }
    }

    private void CompleteObjective()
    {
        completionText.enabled = true;
        completionText.text = $"{objectives[currentObjectiveIndex].description} voltooid!";
        
        Invoke("MoveToNextObjective", 2f); // Ga na 2 seconden door naar de volgende objective
    }

    private void MoveToNextObjective()
    {
        completionText.enabled = false;
        currentObjectiveIndex++;

        if (currentObjectiveIndex < objectives.Count)
        {
            UpdateObjectiveText();
        }
        else
        {
            objectiveText.text = "Gefeliciteerd, alle objectives zijn voltooid!";
            completionText.text = "Je hebt alle doelen gehaald!";
            completionText.enabled = true;
        }
    }
}
