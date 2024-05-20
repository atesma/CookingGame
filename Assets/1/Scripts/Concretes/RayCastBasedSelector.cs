using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastBasedSelector : MonoBehaviour, ISelector
{
    [SerializeField] public Transform _selection;
    public bool Check(Ray ray){
        this._selection = null;
        if(Physics.Raycast(ray, out var hit)){
            this._selection = hit.transform;
            if(_selection.TryGetComponent(out IInteractable interactable)){
                _selection = hit.transform;
                /* if(Input.GetKeyDown(KeyCode.E))
                        interactable.Interact(); */
                return true;
            }
        }

        return false;
    }
    public Transform GetSelection(){
        return _selection;
    }
}
