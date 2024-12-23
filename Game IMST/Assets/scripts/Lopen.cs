using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopen : MonoBehaviour
{
    public AudioSource Walk;
    public GameObject player;
    public Speler speler;

    public bool jumpEnabled;

    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Walk.enabled = true;
            speler.IsWalking = true;
        }
        else
        {
            Walk.enabled = false;
            speler.IsWalking = false;
        }
    }

    bool isGrounded() {
      return Physics.Raycast(transform.position, -Vector3.up, 0.1f + transform.localScale.y);
    }
}
