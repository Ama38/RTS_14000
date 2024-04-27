using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerBattleInventory inventory;                                       
    private InputManager inputManager;
    private PlacerManager placerManager;
    public GameObject UnitToPlace;
    public GameObject UnitToPlacePlacer;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        placerManager = GetComponent<PlacerManager>();
    }
    
    private void Update()
    {
        inputManager.InputHandler();
    }

    //public void SetPrefab(GameObject prefab)
    //{
    //    UnitToPlace = prefab;
    //    UnitToPlacePlacer = prefab.GetComponent<Test>().placerPrefab;
    //    placerManager.UnitToPlace = UnitToPlace;
    //    placerManager.SetUnitToPlacePlacer(UnitToPlacePlacer);
    //}


    public void SelectPrefab(int index)
    {
        placerManager.UnitToPlace = inventory.slots[index];
        placerManager.SetUnitToPlacePlacer(inventory.slots[index].GetComponent<Test>().placerPrefab);
    }
    

}
