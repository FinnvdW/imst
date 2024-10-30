using UnityEngine;

public class ReachTargetObjective : MonoBehaviour
{
    public Objective objective; // Link to the Objective script

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !objective.isCompleted)
        {
            objective.CompleteObjective();
        }
    }
}


