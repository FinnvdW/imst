using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worst : MonoBehaviour
{
    public ObjectiveManager objectiveManager;  // Reference to ObjectiveManager

    void Start()
    {
        if (objectiveManager == null)
        {
            objectiveManager = FindObjectOfType<ObjectiveManager>();
        }
    }

    public void Oppakken()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;

        if (objectiveManager != null)
        {
            objectiveManager.OnObjectiveCompleted();  // Now accessible
        }
        else
        {
            Debug.LogWarning("ObjectiveManager not assigned to Worst script.");
        }
    }
}

