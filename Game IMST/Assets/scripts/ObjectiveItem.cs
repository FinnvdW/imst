using UnityEngine;

public class ObjectiveItem : MonoBehaviour
{
    public string itemID;  // Unieke ID voor dit item

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectiveManager objectiveManager = FindObjectOfType<ObjectiveManager>();
            if (objectiveManager != null)
            {
                objectiveManager.OnItemCollected(itemID);
                Destroy(gameObject);
            }
        }
    }
}