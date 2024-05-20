using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityController : MonoBehaviour
{
    [SerializeField] private List<Light> lights = new List<Light>();

    private void Update() {
        // lights[0].intensity = Random.Range(50,200);
    }
}
