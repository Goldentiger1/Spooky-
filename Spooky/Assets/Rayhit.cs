﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayhit : MonoBehaviour {

    public Transform pointLight;
    public WindowMonster monster;
    public string spook;

    void Start() {
        pointLight = GetComponent<Transform>();
        monster = GameObject.FindGameObjectWithTag("Monster").GetComponent<WindowMonster>();
    }


    void Update() {
        RaycastHit hitInfo;
        if (Physics.Raycast(pointLight.position, pointLight.forward, out hitInfo)) {
            if (hitInfo.collider.tag == "Monster") {
                Fabric.EventManager.Instance.PostEvent(spook);
                monster.windowMonster.transform.position = monster.startPosition;
                monster.currentWaypoint = 0;
            }
        }
    }
}
