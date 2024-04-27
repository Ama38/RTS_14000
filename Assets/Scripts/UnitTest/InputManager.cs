using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Needs to changed using scriptable object, now itsjust variable
    

    private PlayerManager playerManager;
    private PlacerManager placerManager;
    

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    public void InputHandler()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            switch (hit.collider.gameObject.layer) 
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                print(hit.point);
            }
        }
    }

    
}
