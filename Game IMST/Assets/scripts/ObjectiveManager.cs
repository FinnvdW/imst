using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public List<Objective> objectives;
    private int currentObjectiveIndex = 0;

    void Start()
    {
        if (objectives.Count > 0)
        {
            Debug.Log("Objective Activated: " + objectives[currentObjectiveIndex].objectiveName);
        }
    }

    public void OnItemCollected(string itemID)
    {
        if (currentObjectiveIndex < objectives.Count)
        {
            Objective currentObjective = objectives[currentObjectiveIndex];
            currentObjective.CollectItem(itemID);

            if (currentObjective.IsComplete())
            {
                currentObjective.CompleteObjective();
                MoveToNextObjective();
            }
        }
    }

    private void MoveToNextObjective()
    {
        currentObjectiveIndex++;
        if (currentObjectiveIndex < objectives.Count)
        {
            Debug.Log("Objective Activated: " + objectives[currentObjectiveIndex].objectiveName);
        }
        else
        {
            Debug.Log("All objectives completed!");
        }
    }
}