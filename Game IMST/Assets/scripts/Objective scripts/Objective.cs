using UnityEngine;
using System;

public class Objective : MonoBehaviour
{
    public string objectiveDescription; // Short description for the UI
    public bool isCompleted = false;    // Tracks if the objective is done

    // Event to notify when the objective is completed
    public event Action OnObjectiveCompleted;

    // Call this method when the objective is completed
    public void CompleteObjective()
    {
        // Only complete if not already completed
        if (!isCompleted)
        {
            isCompleted = true;
            Debug.Log(objectiveDescription + " completed!");
            
            // Invoke the event to notify listeners
            OnObjectiveCompleted?.Invoke();
        }
    }
}



