     using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// [RequireComponent(typeof(ISelector), typeof(IRayProvider))]
public class SelectionManager : MonoBehaviour
{
    private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;

    private Transform _currentSelection;
    private Transform _selection;

    private void Awake() {
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update() {
        if(_currentSelection != null) _selectionResponse.OnDeselect(_currentSelection);

        _selector.Check(_rayProvider.CreateRay());
        _currentSelection = _selector.GetSelection();

        if(_currentSelection != null)
        {
            _selectionResponse.OnSelect(_currentSelection);
            if(Input.GetKeyDown(KeyCode.E))
                if(_currentSelection.TryGetComponent<IInteractable>(out IInteractable _interactable))
                    _interactable.Interact();
        }
    }
   
}
