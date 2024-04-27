using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryObject", menuName = "ScriptableObjects/SpawnInventoryObject", order = 1)]
public class PlayerBattleInventory : ScriptableObject
{
    // fazik vse polya zdes doljni bit public ok da
    public GameObject Slot1;// inventar slot odin
    public int Slot1Quantity;// kolvo unitov v pervom slote
    public GameObject Slot2;
    public int Slot2Quantity;
    public GameObject Slot3;
    public int Slot3Quantity;
    public GameObject Slot4;
    public int Slot4Quantity;
    public GameObject Slot5;
    public int Slot5Quantity;
    public GameObject Slot6;
    public int Slot6Quantity;
    public GameObject Slot7;
    public int Slot7Quantity;
}
