using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerManager : MonoBehaviour
{
    public GameObject UnitToPlace;
    [SerializeField] private UnitsCounter playerTeam;
    [SerializeField] private UnitsCounter enemyTeam; 
       
    public void SetUnitToPlacePlacer(GameObject prefab)
    {
        UnitToPlacePlacer = prefab;
        Initialize();
    }

    public GameObject UnitToPlacePlacer;

    private GameObject currentPlacer;

    public void PlaceObject(Vector3 position)
    {
        GameObject unitInstance = Instantiate(UnitToPlace);
        unitInstance.transform.position = new Vector3(position.x, 0.5f, position.z);
        unitInstance.GetComponent<Unit>().
    }

    //private bool Check()
    //{
    //    currentPlacer.GetComponent<BoxCollider>().enabled = true;
    //    return currentPlacer.GetComponent<PlacerChecker>().IsFree;
    //}

    public void Initialize()
    {
        Destroy(currentPlacer);
        currentPlacer = Instantiate(UnitToPlacePlacer);
        currentPlacer.transform.position = new Vector3(0, -10, 0);
    }

    public void Sync(Vector3 position)
    {
        currentPlacer.transform.position = new Vector3(position.x, 0.5f, position.z);
    }


}
