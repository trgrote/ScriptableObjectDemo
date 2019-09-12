using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public Event Event;
    public UnityEvent Response;

    void OnEnable()
    {
        Event.Register(this);
    }

    void OnDisable()
    {
        Event.Unregister(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
