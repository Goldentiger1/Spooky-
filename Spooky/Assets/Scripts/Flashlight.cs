using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

    public SteamVR_TrackedController tc;
    public Light flashlight;
    Rayhit r;
    public string light;

    void Start()
    {
        tc.PadClicked += SwitchOnOff;
        r = GetComponentInChildren<Rayhit>();
    }

    public void SwitchOnOff(object sender, ClickedEventArgs e)
    {
        flashlight.enabled = !flashlight.enabled;
        r.enabled = !r.enabled;
        Fabric.EventManager.Instance.PostEvent(light);
    }
}
