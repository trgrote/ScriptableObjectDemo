using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ValueDecrementer : MonoBehaviour
{
    [SerializeField] ValueAsset _value;

    public void Decrement()
    {
        --_value.Value;
    }
}
