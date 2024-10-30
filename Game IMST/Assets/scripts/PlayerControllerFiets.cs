using UnityEngine;

public class PlayerControllerFiets : MonoBehaviour // Make sure class name matches the filename
{
    public AudioSource Fiets;
    public AudioSource Adem;
    public GameObject player;

    public bool jumpEnabled;

    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Fiets.enabled = true;
            Adem.enabled = true;
        }
        else
        {
            Fiets.enabled = false;
            Adem.enabled = false;
        }
    }

    bool isGrounded() {
      return Physics.Raycast(transform.position, -Vector3.up, 0.1f + transform.localScale.y);
    }
}
