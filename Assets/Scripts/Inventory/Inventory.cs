using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public InventoryItem[] Items;

    public void Clear()
    {
        Items = new InventoryItem[0];
    }
}
