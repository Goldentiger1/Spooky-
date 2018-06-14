using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGrab : MonoBehaviour {
    protected Transform cachedTransform;
    [HideInInspector]
    public ControllersGrab currentController;

    public virtual void OnTriggerWasPressed(ControllersGrab controller)
    {
        currentController = controller;
    }

    public virtual void OnTriggerIsBeingPressed(ControllersGrab controller)
    {
    }

    public virtual void OnTriggerWasReleased(ControllersGrab controller)
    {
        currentController = null;
    }

    public virtual void Awake()
    {
        cachedTransform = transform;
        if (!gameObject.CompareTag("InteractableObjects"))
        {
            Debug.LogWarning("This InteractionObject does not have the correct tag, setting it now.", gameObject);
            gameObject.tag = "InteractableObjects";
        }
    }

    public bool IsFree()
    {
        return currentController == null;
    }

    public virtual void OnDestroy()
    {
        if (currentController)
        {
            OnTriggerWasReleased(currentController);
        }
    }
}
