using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DikkeKlantTerug : MonoBehaviour
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
    void Start()
    {
        targetPosition1 = new Vector3(58.45f, 0.5f, -192.8f);
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();
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
        if (speler.heeftVleesOpgehangen == true){
            StartCoroutine(MoveObject(targetPosition1));
        }
    }

    IEnumerator MoveObject(Vector3 targetPosition1)
    {
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
}
