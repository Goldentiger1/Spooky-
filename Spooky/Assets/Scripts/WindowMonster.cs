using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMonster : MonoBehaviour {
    Timer t;
    public float speed = 1f;
    private Transform windowMonster;
    public Vector3 moveDirection;
    public Vector3 startPosition;

    void Start()
    {
        windowMonster = GameObject.Find("FirstEnemy").transform;
    }

    void Update()
    {
        float movement = speed * t.gameTimer;
        moveDirection = new Vector3(-0.98f, 2.5f, -3.761f);
        startPosition = new Vector3(3.73f, 2.5f, -3.761f);
        windowMonster.position = Vector3.MoveTowards(windowMonster.position, moveDirection, movement);
    }


}
