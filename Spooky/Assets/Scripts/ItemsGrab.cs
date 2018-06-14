using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsGrab : MonoBehaviour {

    public SteamVR_TrackedController tc1;
    public SteamVR_TrackedController tc2;

    void Update()
    {
        tc1.TriggerClicked += Grab;
        tc2.TriggerClicked += Grab;
    }

    public void Grab(object sender, ClickedEventArgs e)
    {

    }
}
