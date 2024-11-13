using UnityEngine;

public class CollectionObjective : MonoBehaviour
{
    public Objective objective; // Link to the Objective script
    public int requiredItems = 1; // Number of items to collect
    private int collectedItems = 0; // Current number of collected items

    // This method is called when the item is collected
    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Collected item! Total: " + collectedItems);

        // Check if the required number of items have been collected and complete the objective
        if (collectedItems >= requiredItems && !objective.isCompleted)
        {
            Debug.Log("Required items collected. Completing objective...");
            objective.CompleteObjective();
        }
    }

    // Optional: If you're using collision detection, you can trigger collection here.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player (or item collector) is colliding with this object
        if (other.CompareTag("Player")) // Assuming "Player" tag
        {
            CollectItem();
        }
    }
}



