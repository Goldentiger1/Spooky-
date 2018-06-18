﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMonster : MonoBehaviour {
    Timer t;
    public float speed;
    private float speedMultiplier = 1f;
    private Transform windowMonster;
    public Vector3 moveDirection;
    public Vector3 startPosition;

    void Start()
    {
        windowMonster = GameObject.Find("FirstEnemy").transform;
        t = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        moveDirection = new Vector3(-0.98f, 2.5f, -3.761f);
        startPosition = new Vector3(3.73f, 2.5f, -3.761f);
        if (t.gameTimer > 5){
            if (Vector3.Distance(windowMonster.position, moveDirection) > 0.1f){
                speed = 0.001f;
                if (Vector3.Distance(windowMonster.position, moveDirection) == 0.1f){
                    speed = 0;
                }
            }
            float movement = speed * speedMultiplier;
            windowMonster.position = Vector3.MoveTowards(windowMonster.position, moveDirection, movement);
        }
    }


}