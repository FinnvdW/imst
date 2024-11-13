using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public Image objectiveImage;           // The Image UI element (background)
    public TextMeshProUGUI objectiveText;  // TextMeshProUGUI inside the image
    public Objective[] objectives;         // Predefined ordered list of objectives
    public string[] objectiveDescription;  // Array to store objective descriptions

    private int currentObjectiveIndex = 0; // Tracks the current objective to display

    void Start()
    {
        // Check for issues with missing or mismatched references
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

        // Subscribe to the OnObjectiveCompleted event for each objective
        foreach (Objective objective in objectives)
        {
            if (objective != null)
            {
                objective.OnObjectiveCompleted += OnObjectiveCompleted;  // Subscribe to event
            }
            else
            {
                Debug.LogWarning("An objective in the array is null.");
            }
        }

        // Set the initial state
        UpdateObjectiveUI(); // Display the first objective
    }

    // This method is called when an objective is completed
    public void OnObjectiveCompleted()
    {
        Debug.Log("Objective completed! Moving to next...");

        // Move to the next objective if available
        currentObjectiveIndex++;
        if (currentObjectiveIndex < objectives.Length)
        {
            UpdateObjectiveUI();  // Update UI to show the next objective
        }
        else
        {
            // If all objectives are complete, hide the UI and log completion
            objectiveText.text = " ";
            Debug.Log("All objectives completed!");
        }
    }

    // Update the UI to show the current objective
    void UpdateObjectiveUI()
    {
        if (objectiveText == null || objectiveImage == null)
        {
            Debug.LogError("ObjectiveText or ObjectiveImage is not assigned in the Inspector.");
            return;
        }

        if (currentObjectiveIndex < 0 || currentObjectiveIndex >= objectiveDescription.Length)
        {
            Debug.LogError("Current objective index is out of bounds.");
            return;
        }

        // Debugging log for UI update
        Debug.Log("Updating UI to show objective: " + objectiveDescription[currentObjectiveIndex]);

        // Make the image and text visible
        objectiveImage.gameObject.SetActive(true);
        objectiveText.text = "Objective:\n" + objectiveDescription[currentObjectiveIndex];
    }

    // Optionally, hide the objective UI when all objectives are completed
    public void HideObjectiveUI()
    {
        if (objectiveImage != null)
        {
            objectiveImage.gameObject.SetActive(false);
        }
    }
}

