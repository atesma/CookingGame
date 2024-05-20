using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay()
    {
        return Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f,0));
    }
}
