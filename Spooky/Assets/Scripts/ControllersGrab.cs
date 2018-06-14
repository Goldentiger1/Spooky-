﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllersGrab : MonoBehaviour {

    public Transform snapColliderOrigin;
    public GameObject ControllerModel;

    [HideInInspector]
    public Vector3 velocity;
    [HideInInspector]
    public Vector3 angularVelocity;

    private ObjectsGrab objectBeingInteractedWith;

    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    public ObjectsGrab InteractionObject
    {
        get { return objectBeingInteractedWith; }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void CheckForInteractionObject()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(snapColliderOrigin.position, snapColliderOrigin.lossyScale.x / 2f);

        foreach (Collider overlappedCollider in overlappedColliders)
        {
            if (overlappedCollider.CompareTag("InteractableObjects") && overlappedCollider.GetComponent<ObjectsGrab>().IsFree())
            {
                objectBeingInteractedWith = overlappedCollider.GetComponent<ObjectsGrab>();
                objectBeingInteractedWith.OnTriggerWasPressed(this);
                return;
            }
        }
    }

}
