using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[RequireComponent(typeof(Text))]
public class InventoryRenderer : MonoBehaviour
{
    Text _text;

    [SerializeField] Inventory _inventory;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _inventory.Items.Aggregate("", (a, item) => $"{a}{item.Name}\n");
    }
}
