using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerManager : MonoBehaviour
{
    public GameObject UnitToPlace
    {
        get
        {
            return UnitToPlace;
        }
        set
        {
            UnitToPlace = value;
        }

    }

    public GameObject UnitToPlacePlacer
    {
        get
        {
            return UnitToPlace;
        }
        set
        {
            UnitToPlace = value;
            currentPlacer = value;
            Initialize();   
        }

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
