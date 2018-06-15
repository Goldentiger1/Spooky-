using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGrab : ObjectsGrab {

    public bool hideControllerModelOnGrab;
    private Rigidbody rb;

    public override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody>();
    }

    private void AddFixedJointToController(ControllersGrab controller)
    {
        FixedJoint fx = controller.gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        fx.connectedBody = rb;
    }

    private void RemoveFixedJointFromController(ControllersGrab controller)
    {
        if (controller.gameObject.GetComponent<FixedJoint>())
        {
            FixedJoint fx = controller.gameObject.GetComponent<FixedJoint>();
            fx.connectedBody = null;
            Destroy(fx);
        }
    }

    public override void OnTriggerWasPressed(ControllersGrab controller)
    {
        base.OnTriggerWasPressed(controller);

        if (hideControllerModelOnGrab)
        {
            controller.HideControllerModel();
        }

        AddFixedJointToController(controller);
    }

    public override void OnTriggerWasReleased(ControllersGrab controller)
    {
        base.OnTriggerWasReleased(controller);

        if (hideControllerModelOnGrab)
        {
            controller.ShowControllerModel();
        }

        rb.velocity = controller.velocity;
        rb.angularVelocity = controller.angularVelocity;

        RemoveFixedJointFromController(controller);
    }
}
