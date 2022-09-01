using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionBehaviour : MonoBehaviour
{
    public UnityEvent onCollisionEnterEvent, onCollisionExitEvent, onDestroyEvent;

    private void OnCollisionEnter(Collision collision)
    {
        onCollisionEnterEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        onCollisionExitEvent.Invoke();
    }

    private void OnDestroy()
    {
        onDestroyEvent.Invoke();
    }
}
