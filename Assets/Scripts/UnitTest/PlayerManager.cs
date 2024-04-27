using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private InputManager inputManager;
    private PlacerManager placerManager;
    public GameObject UnitToPlace;
    public GameObject UnitToPlacePlacer;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
    }
    
    private void Update()
    {
        inputManager.InputHandler();
    }

    public void SetPrefab(GameObject prefab, GameObject prefabPlacer)
    {
        UnitToPlace = prefab;
        UnitToPlacePlacer = prefabPlacer;
        placerManager.UnitToPlace = UnitToPlace;
        placerManager.UnitToPlacePlacer = UnitToPlacePlacer;
    }
    

}
