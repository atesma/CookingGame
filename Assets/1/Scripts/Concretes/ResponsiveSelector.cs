using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveSelector : MonoBehaviour, ISelector
{
    [SerializeField] private List<Transform> selectables;
    [SerializeField] private Transform _selection;
    [SerializeField] private float threshold;
    public bool Check(Ray ray)
    {
        _selection = null;

        float closest = 0;
        for(int i= 0; i<selectables.Count; i++){

        var vector1 = ray.direction;
        var vector2 = selectables[i].position - ray.origin;

        float lookPercentage = Vector3.Dot(vector1.normalized, vector2.normalized); 

        if(lookPercentage > threshold &&  lookPercentage > closest){
            closest = lookPercentage;
            _selection = selectables[i].transform;
            Debug.Log("Hell yeah baby");
            return true;
            }      
        } 


        Debug.Log("fuck no ");
        return false;  

    }
    public Transform GetSelection() => _selection;
}