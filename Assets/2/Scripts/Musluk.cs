using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musluk : InteractableObject
{
    [SerializeField] ParticleSystem particleOne;
    [SerializeField] Animator animator;
    public override void Interact()
    {
        animator.SetBool("isOpen" , !animator.GetBool("isOpen"));
        
        if(particleOne.isPlaying)
            particleOne.Stop();
        else
            particleOne.Play();
    }
}
