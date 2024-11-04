using UnityEngine;
using TMPro;

public class ObjectiveManager : MonoBehaviour
{
    public TextMeshProUGUI objectiveText; // Text UI to display current objective
    public Objective[] objectives;         // Predefined ordered list of objectives
    public string[] objectiveDescription;  // Array to store objective descriptions
    
    private int currentObjectiveIndex = 0; // Tracks the current objective to display

    void Start()
    {
        // Validate the objective array
        if (objectives == null || objectives.Length == 0)
        {
            Debug.LogWarning("No objectives assigned in the ObjectiveManager.");
            return;
        }
        
        // Validate the descriptions array
        if (objectiveDescription == null || objectiveDescription.Length == 0)
        {
            Debug.LogWarning("No descriptions assigned in the ObjectiveManager.");
            return;
        }

        // Validate that the count of objectives matches the count of descriptions
        if (objectives.Length != objectiveDescription.Length)
        {
            Debug.LogError("Mismatch between number of objectives and descriptions. Ensure each objective has a description.");
            return;
        }

        // Register event listeners for each objective
        foreach (Objective objective in objectives)
        {
            if (objective != null) // Check for null references
            {
                objective.OnObjectiveCompleted += OnObjectiveCompleted;
            }
            else
            {
                Debug.LogWarning("An objective in the array is null.");
            }
        }

        UpdateObjectiveUI(); // Display the first objective
    }

    void OnObjectiveCompleted()
    {
        // Move to the next objective if available
        currentObjectiveIndex++;
        if (currentObjectiveIndex < objectives.Length)
        {
            UpdateObjectiveUI();
        }
        else
        {
            // All objectives are complete
            objectiveText.text = " ";
            Debug.Log("All objectives completed!");
        }
    }

    void UpdateObjectiveUI()
    {
        // Display only the current objective description from the array
        if (objectiveText == null) return; // Ensure objectiveText is assigned
        if (currentObjectiveIndex < 0 || currentObjectiveIndex >= objectiveDescription.Length) return; // Valid range check

        objectiveText.text = "Objective:\n" + objectiveDescription[currentObjectiveIndex];
    }
}
