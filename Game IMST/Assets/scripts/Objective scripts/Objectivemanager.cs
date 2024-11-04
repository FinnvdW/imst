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
        if (objectives == null || objectives.Length == 0)
        {
            Debug.LogWarning("No objectives assigned in the ObjectiveManager.");
            return;
        }

        if (objectiveDescription == null || objectiveDescription.Length == 0)
        {
            Debug.LogWarning("No descriptions assigned in the ObjectiveManager.");
            return;
        }

        if (objectives.Length != objectiveDescription.Length)
        {
            Debug.LogError("Mismatch between number of objectives and descriptions. Ensure each objective has a description.");
            return;
        }

        foreach (Objective objective in objectives)
        {
            if (objective != null)
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

    // Make this method public so it can be accessed from other scripts
    public void OnObjectiveCompleted()
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
        if (objectiveText == null) return;
        if (currentObjectiveIndex < 0 || currentObjectiveIndex >= objectiveDescription.Length) return;

        objectiveText.text = "Objective:\n" + objectiveDescription[currentObjectiveIndex];
    }
}
