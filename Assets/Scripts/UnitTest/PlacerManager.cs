using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerManager : MonoBehaviour
{
    public GameObject UnitToPlace;

    //public GameObject UnitToPlacePlacer
    //{
    //    get
    //    {
    //        return UnitToPlacePlacer;
    //    }
    //    set
    //    {
    //        UnitToPlace = value;
    //        currentPlacer = value;
    //        Initialize();
    //    }

    //}

    public void SetUnitToPlacePlacer(GameObject prefab)
    {
        UnitToPlacePlacer = prefab;
        Initialize();
    }

    public GameObject UnitToPlacePlacer;

    private void Awake()
    {
        //Initialize();
    }

    private GameObject currentPlacer;

    public void PlaceObject(Vector3 position)
    {
        GameObject unitInstance = Instantiate(UnitToPlace);
        unitInstance.transform.position = position;
    }

    public void Initialize()
    {
        currentPlacer = Instantiate(UnitToPlacePlacer);
        currentPlacer.transform.position = new Vector3(0, -10, 0);
    }

    public void Sync(Vector3 position)
    {
        currentPlacer.transform.position = new Vector3(position.x, 0.5f, position.z);
    }


}
