using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryObject", menuName = "ScriptableObjects/SpawnInventoryObject", order = 1)]
public class PlayerBattleInventory : ScriptableObject
{
    // fazik vse polya zdes doljni bit public ok da
    public GameObject[] slots = new GameObject[7];
    public int[] numberOfUnits = new int[7];    
}
