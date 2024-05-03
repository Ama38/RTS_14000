using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class RashidAI : UnitAI
{
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        AssignTeam();
        AddToTeam();
    }

    public override void Attack() { }
    public override void SpecialAbility() { }
    public override void Move()
    {
        if (currentTarget == null)
        {
            FindTarget();
            return;
        }
        if (!currentTarget.IsDestroyed())
        {
            agent.SetDestination(currentTarget.transform.position);
        }
        else
        {
            FindTarget();
        }
    }

    public override void Interact() { }
    public override void FindTarget()
    {
        if (enemyUnits.Count == 0)
        {
            currentTarget = null;   
            return;
        }
        currentTarget = enemyUnits[0];
        foreach (GameObject unit in enemyUnits)
        {
            if (Vector3.Distance(gameObject.transform.position, unit.transform.position) < Vector3.Distance(gameObject.transform.position, currentTarget.transform.position))
            {
                currentTarget = unit;
            }
        }
    }
}
