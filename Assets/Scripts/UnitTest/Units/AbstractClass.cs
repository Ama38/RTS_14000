using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Unit : MonoBehaviour
{
    public enum Team
    {
        Player,
        Enemy
    }
    public Team UnitTeam;
    public bool IsAlive;

    public abstract GameObject GetPlacerPrefab();
}

public abstract class UnitAI : MonoBehaviour
{


    private List<GameObject> allyUnits;
    private List<GameObject> enemyUnits;
    private NavMeshAgent agent;
    private GameObject currentTarget;

    public abstract void Attack();
    public abstract void SpecialAbility();
    public abstract void Move();

    public abstract void Interact();
    public abstract void FindTarget();
}

