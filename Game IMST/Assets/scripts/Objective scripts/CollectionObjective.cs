using UnityEngine;

public class CollectionObjective : MonoBehaviour
{
    public Objective objective; // Link to the Objective script
    public int requiredItems = 1;
    private int collectedItems = 0;

    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Collected item! Total: " + collectedItems);
        if (collectedItems >= requiredItems && !objective.isCompleted)
        {
            objective.CompleteObjective();
        }
    }
}



