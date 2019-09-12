using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ItemRender : MonoBehaviour
{
    Image _image;
    [SerializeField] InventoryItem _item;

    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _item.Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
