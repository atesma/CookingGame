using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocak : InteractableObject
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private GameObject lightt;
    public override void Interact()
    {
        if(particle.isPlaying)
        {
            particle.Stop();
            lightt.SetActive(false);
        }
        else
        {
            particle.Play();
            lightt.SetActive(true);
        }
        
    }
}
