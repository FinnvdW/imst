using UnityEngine;
using TMPro;

public class Objective : MonoBehaviour
{
    public string description; // Beschrijving van het objective
    public int targetCount;    // Aantal benodigde items/acties om te voltooien
    private int currentCount;  // Huidige voortgang

    public bool IsCompleted => currentCount >= targetCount; // Check of het objective voltooid is

    // Voeg een item toe aan de voortgang
    public void AddProgress(int count = 1)
    {
        currentCount += count;
        if (currentCount > targetCount) currentCount = targetCount;
    }

    // Reset de voortgang voor een nieuwe poging of om te hergebruiken
    public void ResetProgress()
    {
        currentCount = 0;
    }

    public string GetProgressText()
    {
        return $"{description}: {currentCount}/{targetCount}";
    }
}
