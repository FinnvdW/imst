using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GordonWalk : MonoBehaviour
{
    public Animator animator;
    Rigidbody rb;
    public Speler speler;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (speler.IsWalking == true)
        {
            animator.SetTrigger("walking");
        }else if (speler.IsWalking == false){
            animator.SetTrigger("notwalking");
        }
    }
}
