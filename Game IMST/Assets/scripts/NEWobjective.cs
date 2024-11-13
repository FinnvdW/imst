using System.Collections;
using UnityEngine;

public class NEWobjective : MonoBehaviour
{
    public string objectiveDescription;  // Objective description
    public bool isCompleted = false;     // Tracks if the objective is completed
    public float completionDelay = 0f;   // Optional delay before completion (in seconds)

    public ObjectiveManager objectiveManager;  // Reference to the ObjectiveManager to notify when objective is completed

    // Call this method to complete the objective
    public void CompleteObjective()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Debug.Log(objectiveDescription + " completed!");

            // Notify the ObjectiveManager about the completion
            if (objectiveManager != null)
            {
                objectiveManager.OnObjectiveCompleted();  // Update the manager
            }
            else
            {
                Debug.LogWarning("ObjectiveManager not assigned to Objective script.");
            }
        }
    }

    // Optionally, a method to start a completion process with a delay
    public IEnumerator CompleteObjectiveWithDelay()
    {
        if (completionDelay > 0f)
        {
            yield return new WaitForSeconds(completionDelay);
        }

        CompleteObjective();  // Complete the objective after delay
    }
}
