using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worst : MonoBehaviour
{
    public ObjectiveManager objectiveManager;  // Reference to ObjectiveManager
    public Speler speler;
    void Start()
    {
        if (objectiveManager == null)
        {
            objectiveManager = FindObjectOfType<ObjectiveManager>();
        }
    }

    void Update(){
        if(speler.heeftGepraat != true){
            GetComponent<BoxCollider>().enabled = false;
        } else{
            StartCoroutine(WorstKunnenPakken());
            GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void Oppakken()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        speler.WorstVerkocht = true;
        if (objectiveManager != null)
        {
            objectiveManager.OnObjectiveCompleted();  // Now accessible
        }
        else
        {
            Debug.LogWarning("ObjectiveManager not assigned to Worst script.");
        }
    }

    IEnumerator WorstKunnenPakken(){
        yield return new WaitForSeconds(20.3f);
    }
}

