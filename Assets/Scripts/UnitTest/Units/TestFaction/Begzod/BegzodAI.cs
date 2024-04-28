using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class BegzodAI : MonoBehaviour, IUnitAI
{
    private List<GameObject> allyUnits;
    private List<GameObject> enemyUnits;
    private NavMeshAgent agent;
    private GameObject currentTarget;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        allyUnits = GameObject.Find("PlayerUnitsCounter").GetComponent<UnitsCounter>().units;
        enemyUnits = GameObject.Find("EnemyUnitsCounter").GetComponent<UnitsCounter>().units;
    }

    public void Attack()
    {

    }

    public void SpecialAbility() { }
    public void Move()
    {
        if (currentTarget != null)
        {
            agent.SetDestination(currentTarget.transform.position);
        }
        else if (currentTarget == null)
        {
            FindTarget();
        }
    }

    public void Interact() { }
    public void FindTarget()
    {
        if (currentTarget == null)
        {
            if (enemyUnits.Count == 0)
            {
                return;
            }
            currentTarget = enemyUnits[0];
            foreach(GameObject unit in enemyUnits)
            {
                if (Vector3.Distance(gameObject.transform.position, unit.transform.position) < Vector3.Distance(gameObject.transform.position, currentTarget.transform.position))
                {
                    currentTarget = unit;
                }
            }
        }
    }
}
