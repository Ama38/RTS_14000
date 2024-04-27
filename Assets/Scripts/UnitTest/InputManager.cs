using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    

    private PlayerManager playerManager;
    private PlacerManager placerManager;
    

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        placerManager = GetComponent<PlacerManager>();  
    }

    public void InputHandler()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            switch (hit.collider.gameObject.layer)
            {
                case 0:
                    placerManager.Sync(hit.point);
                    if (Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject())
                    {
                        placerManager.PlaceObject(hit.point);
                        print(hit.point);
                    }
                    break;

            }
            
        }
    }

    
}
