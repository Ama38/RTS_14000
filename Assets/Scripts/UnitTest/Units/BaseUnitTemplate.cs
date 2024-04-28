using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    public void Attack() { }
    public void Move() { }
    public void Interact() { }
    public void FindTarget() { }
}
