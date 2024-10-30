/*using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public TextMeshProUGUI objectiveText; // Assign in the Inspector to your TextMeshPro UI element
    private Objective[] objectives;       // Array to store all objectives

    void Start()
    {
        // Find all Objective components in the scene
        objectives = FindObjectsOfType<Objective>();
        if (objectives == null || objectives.Length == 0)
        {
            Debug.LogWarning("No objectives found in the scene.");
        }

        // Check if objectiveText is assigned
        if (objectiveText == null)
        {
            Debug.LogError("Objective TextMeshPro UI is not assigned in the ObjectiveManager!");
            return; // Exit if objectiveText is null to prevent further errors
        }

        UpdateObjectiveUI();
    }

    void Update()
    {
        // Update only if objectiveText is assigned
        if (objectiveText != null)
        {
            if (AreAllObjectivesComplete())
            {
                Debug.Log("All objectives completed!");
                objectiveText.text = "All objectives completed!";
            }
            else
            {
                UpdateObjectiveUI();
            }
        }
    }

    void UpdateObjectiveUI()
    {
        // Check if objectiveText is null before updating text
        if (objectiveText == null) return;

        // Reset objectiveText display
        objectiveText.text = "Objectives:\n";
        
        // Loop through objectives, adding each to the display
        foreach (Objective objective in objectives)
        {
            if (objective != null) // Prevents null reference if an objective is missing
            {
                // Show [X] if completed, [ ] if incomplete
                objectiveText.text += (objective.isCompleted ? "[X] " : "[ ] ") + objective.objectiveDescription + "\n";
            }
            else
            {
                Debug.LogWarning("Objective list contains a null reference.");
            }
        }
    }

    bool AreAllObjectivesComplete()
    {
        foreach (Objective objective in objectives)
        {
            if (objective != null && !objective.isCompleted)
                return false;
        }
        return true;
    }
}*/
