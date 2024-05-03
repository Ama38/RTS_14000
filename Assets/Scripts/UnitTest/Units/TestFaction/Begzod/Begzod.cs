using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begzod : Unit
{
    //public new Team UnitTeam;
    //public new bool IsAlive;
    //private GameObject placerPrefab;
    //private UnitAI AI;

    public override GameObject GetPlacerPrefab()
    {
        return placerPrefab;
    }
    private void Awake()
    {
        AI = GetComponent<UnitAI>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        AI.Move();
    }
}
