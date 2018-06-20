using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMonster : MonoBehaviour
{

    public List<float> wait;
    public List<Vector3> waypoints;

    public float speed;
    public Vector3 startPosition;

    public Transform windowMonster;
    private int waitTime = 0;
    public float waitTimer = 0;

    public int currentWaypoint = 0;

    private Vector3 p1 = new Vector3(0.941f, 2.096f, -3.251f);
    private Vector3 p2 = new Vector3(-0.099f, 2.096f, -3.251f);
    private Vector3 p3 = new Vector3(0.063f, 1.727f, -1.63f);
    private Vector3 p4 = new Vector3(0.063f, 0.329f, -1.63f);
    private Vector3 p5 = new Vector3(0.063f, 0.329f, -1.168f);

    void Awake()
    {
        wait.Add(15);
        wait.Add(10);
        wait.Add(5);
        wait.Add(3);
        wait.Add(1);

        waitTimer = wait[0];

        waypoints.Add(p1);
        waypoints.Add(p2);
        waypoints.Add(p3);
        waypoints.Add(p4);
        waypoints.Add(p5);
    }

    void Start()
    {
        windowMonster = GameObject.Find("FirstEnemy").transform;

    }

    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWaypoint]) < Vector3.kEpsilon) {
            if (waitTimer <= 0) {
                currentWaypoint = (currentWaypoint + 1) % waypoints.Count;
                waitTimer = wait[currentWaypoint];
            } else {
                waitTimer -= Time.deltaTime;
            }
        } else {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint], speed * Time.deltaTime);
        }
    }
}
