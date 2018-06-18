using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text gameTime;
    public float gameTimer = 0f;


	void Update () {
        gameTimer += Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;
        int hours = (int)(gameTimer / 3600) % 24;

        string timerstring = string.Format("{0:0}:{1:00}:{2:00}",hours,minutes,seconds);

        gameTime.text = timerstring;
	}
}
