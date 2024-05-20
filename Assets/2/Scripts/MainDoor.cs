using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : InteractableObject
{
    Animator animator;
    Outline outline;
    new Collider collider;

    private void Awake() 
    {
        animator = GetComponent<Animator>();
        outline = GetComponent<Outline>();
        collider = GetComponent<Collider>();
    }
    public override void Interact()
    {
        collider.enabled = false;
        outline.enabled = false;
        animator.SetTrigger("Start");
    }
}
