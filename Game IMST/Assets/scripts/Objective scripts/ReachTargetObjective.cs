using UnityEngine;

public class ReachTargetObjective : MonoBehaviour
{
    public Objective objective; // Link to the Objective script

    void OnTriggerEnter(Collider other)
    {
        // Check if the triggering object has the "Player" or "Bakfiets" tag
        if ((other.CompareTag("Player") || other.CompareTag("Bakfiets")) && !objective.isCompleted)
        {
            objective.CompleteObjective();
            Debug.Log("Objective marked as completed by " + other.tag);
        }
    }
}

