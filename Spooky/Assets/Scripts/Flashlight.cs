using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

    public SteamVR_TrackedController tc;
    public Light flashlight;

    void Update()
    {
        tc.PadClicked += SwitchOnOff;
    }

    public void SwitchOnOff(object sender, ClickedEventArgs e)
    {
        flashlight.enabled = !flashlight.enabled;
    }
}
