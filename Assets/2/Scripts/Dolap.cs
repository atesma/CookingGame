using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolap : InteractableObject
{
    Animator animator;
    private void Awake() 
    {
        animator = GetComponent<Animator>();
    }
    public override void Interact()
    {
        animator.SetBool("isOpen" , !animator.GetBool("isOpen"));
    }
}
