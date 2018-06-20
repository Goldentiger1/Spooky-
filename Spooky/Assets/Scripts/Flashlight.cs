using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

    public SteamVR_TrackedController tc;
    public Light flashlight;
    Rayhit r;

    void Start()
    {
        tc.PadClicked += SwitchOnOff;
    }

    public void SwitchOnOff(object sender, ClickedEventArgs e)
    {
        flashlight.enabled = !flashlight.enabled;
        r.enabled = !r.enabled;

    }
}
