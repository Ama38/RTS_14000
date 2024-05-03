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
    //public bool IsAlive;
    public GameObject placerPrefab;
    public UnitAI AI;
    public abstract GameObject GetPlacerPrefab();
}

public abstract class UnitAI : MonoBehaviour
{


    public List<GameObject> allyUnits;
    public List<GameObject> enemyUnits;
    public NavMeshAgent agent;
    public GameObject currentTarget;

    public virtual void AddToTeam()
    {
        allyUnits.Add(gameObject);
    }

    public virtual void AssignTeam()
    {
        if (GetComponent<Unit>().UnitTeam == Unit.Team.Player)
        {
            allyUnits = GameObject.Find("PlayerUnitsCounter").GetComponent<UnitsCounter>().units;
            enemyUnits = GameObject.Find("EnemyUnitsCounter").GetComponent<UnitsCounter>().units;
        }
        else if (GetComponent<Unit>().UnitTeam == Unit.Team.Enemy)
        {
            allyUnits = GameObject.Find("EnemyUnitsCounter").GetComponent<UnitsCounter>().units;
            enemyUnits = GameObject.Find("PlayerUnitsCounter").GetComponent<UnitsCounter>().units;
        }
    }
    public abstract void Attack();
    public abstract void SpecialAbility();
    public abstract void Move();

    public abstract void Interact();
    public abstract void FindTarget();
}

