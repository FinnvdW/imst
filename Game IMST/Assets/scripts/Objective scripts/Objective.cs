using UnityEngine;

public class Objective : MonoBehaviour
{
    public string objectiveDescription; // Short description for the UI
    public bool isCompleted = false;    // Tracks if the objective is done

    // Call this method when the objective is completed
    public void CompleteObjective()
    {
        isCompleted = true;
        Debug.Log(objectiveDescription + " completed!");
    }
}


