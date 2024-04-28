using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begzod : MonoBehaviour, IUnit
{
    public GameObject placerPrefab;
    private IUnitAI AI;

    public GameObject GetPlacerPrefab()
    {
        return placerPrefab;
    }
    private void Awake()
    {
        AI = GetComponent<IUnitAI>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        AI.Move();
    }
}
