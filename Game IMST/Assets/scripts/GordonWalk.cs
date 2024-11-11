using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GordonWalk : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Walking()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            animator.SetTrigger("walking");
        }
    }
}
