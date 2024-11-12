using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pratenDikkeKlant : MonoBehaviour
{
    Image image;
    AudioSource audioSource;
    public AudioClip KlantYap;
    public AudioClip KlantYap2;
    public AudioClip KlantYap3;
    public AudioClip GordonYap;
    public AudioClip GordonYap2;
    public AudioClip GordonYap3;
    public TextMeshProUGUI GordonTalking;
    public TextMeshProUGUI GordonTalking1;
    public TextMeshProUGUI GordonTalking2;
    public TextMeshProUGUI GordonTalking3;
    public TextMeshProUGUI KlantTalking;
    public TextMeshProUGUI KlantTalking1;
    public TextMeshProUGUI KlantTalking2;
    public TextMeshProUGUI KlantTalking3;
    public Image Klant;
    public Image Gordon;
    Animator animator;
    public Speler speler;
    public GameObject objectToRotate;
    public float rotationSpeed = 180f;  // Speed of rotation (degrees per second)
    private bool isRotating = false;
    private Quaternion targetRotation;
    public float moveSpeed = 5f;
    public GameObject objectToMove;
    private float initialRotationY;     // To store the initial Y rotation
    private float targetRotationY;
    private bool isMoving = false;
    private Vector3 targetPosition1;    
    private Vector3 targetPosition2;    
    private Vector3 startPosition;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();
        GordonTalking.enabled = false;
        Gordon.enabled = false;
        targetPosition1 = new Vector3(73.52f, 0.5f, -187.86f); 
        targetPosition2 = new Vector3(73.52f, 0.5f, 506f);
    }

    public void Converseren(){
        animator.SetTrigger("converseren");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.text = "Welcome, what can I get for you today?";
        GordonTalking.enabled = true;
        StartCoroutine(Tekstweg());
        Gordon.enabled = true;
        StartCoroutine(ImageWeg());
        KlantTalking.text = "Oh wow, it seems like you're almost sold oud Gordon! I'll take everything you have left.";
        StartCoroutine(KlantYapping());
        GordonTalking1.text = "Alright, I'll get it for you. How's the wife been?";
        StartCoroutine(GordonYapping2());
        KlantTalking1.text = "To be honest, she is still slightly ill, but I am sure she will be fine in no time.";
        StartCoroutine(KlantYapping2());
        GordonTalking2.text = "Aha, well, I'm sure she will be.";
        StartCoroutine(GordonYapping3());
    }

    void Update(){
        if (speler.WorstVerkocht == true){
        Invoke("RotateObject", 8f);
        GordonTalking.text = "Here you go, that's my last of my finest meat.";
        StartCoroutine(GordonYapping5());
        KlantTalking.text = "Much appreciated as always, Gordon! I will return when you have some new stock.";
        StartCoroutine(KlantYapping3());
        GordonTalking1.text = "Thanks, see you next time!";
        StartCoroutine(GordonYapping4());
        GordonTalking2.text = "Damn it, now I'm really all out of meat. Guess I'll go to Harm the farmer.";
        StartCoroutine(GordonYapping6());
        GordonTalking3.text = "But first I'll need to get my key back from Jimmy.";
        StartCoroutine( GordonYapping7());
        StartCoroutine(RotateObjectAfterDelay(8.2f));
        }
        speler.WorstVerkocht = false;
        Debug.Log($"isRotating: {isRotating}");

        // If the object is rotating, handle the rotation
        if (isRotating)
        {
            RotateObject();
        }else if (isMoving){
            StartCoroutine(MoveObject(targetPosition1));
            StartCoroutine(MoveObject2(targetPosition2));
        }
    }

    IEnumerator Tekstweg(){
        yield return new WaitForSeconds(4f);
        GordonTalking.enabled = false;
    }

    IEnumerator ImageWeg(){
        yield return new WaitForSeconds(4f);
        Gordon.enabled = false;
    }

    IEnumerator KlantYapping(){
        yield return new WaitForSeconds(4.1f);
        audioSource.PlayOneShot(KlantYap);
        KlantTalking.enabled = true;
        Klant.enabled = true;
        yield return new WaitForSeconds(4f);
        KlantTalking.enabled = false;
        Klant.enabled = false;
    }
    IEnumerator GordonYapping2(){
        yield return new WaitForSeconds(8.2f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking1.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(3f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator KlantYapping2(){
        yield return new WaitForSeconds(11.3f);
        audioSource.PlayOneShot(KlantYap2);
        KlantTalking1.enabled = true;
        Klant.enabled = true;
        yield return new WaitForSeconds(5f);
        KlantTalking1.enabled = false;
        Klant.enabled = false;
    }

    IEnumerator GordonYapping3(){
        yield return new WaitForSeconds(16.4f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking2.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(3f);
        GordonTalking2.enabled = false;
        Gordon.enabled = false;
        speler.heeftGepraat = true;
    }

    IEnumerator GordonYapping5(){
        audioSource.PlayOneShot(GordonYap);
        GordonTalking.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(3f);
        GordonTalking.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator KlantYapping3(){
        yield return new WaitForSeconds(3.1f);
        audioSource.PlayOneShot(KlantYap2);
        KlantTalking.enabled = true;
        Klant.enabled = true;
        yield return new WaitForSeconds(5f);
        KlantTalking.enabled = false;
        Klant.enabled = false;
    }

    IEnumerator RotateObjectAfterDelay(float delay)
    {
        Debug.Log($"Starting RotateObjectAfterDelay for {delay} seconds...");

        // Wait for the specified time before rotating
        yield return new WaitForSeconds(delay);

        Debug.Log("Wait time finished. Proceeding with rotation.");

        // Start rotating the object
        isRotating = true;

        // Save the initial Y rotation and set the target rotation (180 degrees)
        initialRotationY = objectToRotate.transform.eulerAngles.y;
        targetRotationY = initialRotationY - 180f;  // Rotate 180 degrees in the negative Y direction
        // Make sure the angle is within 0 to 360 range
        if (targetRotationY < 0f) targetRotationY += 360f;
        yield return new WaitForSeconds(1f);
        isRotating = false;
        Debug.Log($"Starting rotation. Initial: {initialRotationY}, Target: {targetRotationY}");
        yield return new WaitUntil(() => !isRotating); // Wait until rotation finishes
        
        // After rotation is complete, start moving to targetPosition1
        isMoving = true;
        yield return new WaitUntil(() => !isMoving);  // Wait until first movement completes

        // After reaching the first target position, move to targetPosition2
        targetPosition1 = targetPosition2; // Set second target
        yield return new WaitUntil(() => !isMoving);
    }

    void RotateObject()
    {
        Debug.Log("RotateObject method is running.");

        // Rotate the object by 'rotationSpeed' degrees per second around the Y-axis
        float step = rotationSpeed * Time.deltaTime;  // Degrees per frame
        objectToRotate.transform.Rotate(0f, step, 0f);

        // Get the current Y rotation of the object
        float currentRotationY = objectToRotate.transform.eulerAngles.y;

        // Normalize the angle (to avoid wraparound issues)
        if (currentRotationY > 180f) currentRotationY -= 360f;

        // Check if the object has completed 180 degrees of rotation
        if (Mathf.Abs(currentRotationY - targetRotationY) < 0.1f)
        {
            // Correctly set the rotation to the exact target rotation
            objectToRotate.transform.rotation = Quaternion.Euler(0f, targetRotationY, 0f);

            // Stop rotating
            isRotating = false;
            Debug.Log("Rotation completed! Stopping rotation.");
            StartCoroutine(MoveToNextLocation(targetPosition1));
        }
    }
    IEnumerator MoveToNextLocation(Vector3 targetPosition1)
    {
        isMoving = true;

        float distance = Vector3.Distance(objectToMove.transform.position, targetPosition1);
        while (distance > 0.1f) // While not very close to target position
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition1, moveSpeed * Time.deltaTime);
            distance = Vector3.Distance(objectToMove.transform.position, targetPosition1); // Update the distance
            yield return null; // Wait until next frame
        }

        objectToMove.transform.position = targetPosition1; // Ensure it reaches the exact position
        isMoving = false; // Movement complete
        Debug.Log("Movement completed!");
    }

    IEnumerator MoveObject(Vector3 targetPosition1)
    {
        animator.SetTrigger("klaar");
        float distance = Vector3.Distance(objectToMove.transform.position, targetPosition1);
        while (distance > 0.1f) // While not very close to target position
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition1, moveSpeed * Time.deltaTime);
            distance = Vector3.Distance(objectToMove.transform.position, targetPosition1); // Update the distance
            yield return null; // Wait until next frame
        }

        objectToMove.transform.position = targetPosition1; // Ensure it reaches the exact position
        isMoving = false; // Movement complete
        Debug.Log("Movement completed!");
    }

    IEnumerator MoveObject2(Vector3 targetPosition2)
    {
        float distance = Vector3.Distance(objectToMove.transform.position, targetPosition2);
        while (distance > 0.1f) // While not very close to target position
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition1, moveSpeed * Time.deltaTime);
            distance = Vector3.Distance(objectToMove.transform.position, targetPosition2); // Update the distance
            yield return null; // Wait until next frame
        }

        objectToMove.transform.position = targetPosition2; // Ensure it reaches the exact position
        isMoving = false; // Movement complete
        Debug.Log("Movement completed!");
    }

    IEnumerator GordonYapping4(){
        yield return new WaitForSeconds(8.2f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking1.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(2f);
        GordonTalking1.enabled = false;
        Gordon.enabled = false;
    }

    IEnumerator GordonYapping6(){
        yield return new WaitForSeconds(13.2f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking2.enabled = true;
        Gordon.enabled = true;
        yield return new WaitForSeconds(5f);
        GordonTalking2.enabled = false;
    }

    IEnumerator GordonYapping7(){
        yield return new WaitForSeconds(18.3f);
        audioSource.PlayOneShot(GordonYap);
        GordonTalking3.enabled = true;
        yield return new WaitForSeconds(5f);
        GordonTalking3.enabled = false;
        Gordon.enabled = false;
    }
}
