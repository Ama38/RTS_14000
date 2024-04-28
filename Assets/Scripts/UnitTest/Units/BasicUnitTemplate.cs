using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    public GameObject GetPlacerPrefab()
    {
        return new GameObject();
    }
}


public abstract class Unit : MonoBehaviour
{
    public int team;
}
