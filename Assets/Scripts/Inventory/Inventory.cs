using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<InventoryItem> Items = new List<InventoryItem>();

    public void Clear()
    {
        Items.Clear();
    }

    public void Add(InventoryItem item)
    {
        Items.Add(item);
    }
}
