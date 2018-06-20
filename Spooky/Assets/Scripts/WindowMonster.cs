using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMonster : MonoBehaviour {

    public List<float> wait;
    public List<Vector3> waypoints;

    public float speed;        
    public Vector3 startPosition;
    public float time;
    public float time2;

    private float speedMultiplier = 1f;
    private Transform windowMonster;
    private float waitTime;
    private bool doOnce;

    private Vector3 p1 = new Vector3(1.651f, 2.5f, -3.761f);
    private Vector3 p2 = new Vector3(-0.1f, 2.5f, -3.761f);
    private Vector3 p3 = new Vector3(-0.921f, 2.5f, -3.761f);
    private Vector3 p4 = new Vector3(-0.921f, 2.5f, -2.168f);
    private Vector3 p5 = new Vector3(-0.921f, 0.62f, -2.168f);
    private Vector3 p6 = new Vector3(-1.71f, 0.62f, -2.168f);
    private Vector3 p7 = new Vector3(1.651f, 2.5f, -3.761f);

    void Awake()
    {
        wait.Add(10);
        wait.Add(5);
        wait.Add(3);
        wait.Add(1);
        wait.Add(1);

        waypoints.Add(p1);
        waypoints.Add(p2);
        waypoints.Add(p3);
        waypoints.Add(p4);
        waypoints.Add(p5);
        waypoints.Add(p6);
    }

    void Start()
    {
        windowMonster = GameObject.Find("FirstEnemy").transform;
        doOnce = false;
    }

    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        foreach(float w in wait)
        {
            print(w);
            /*
            while(time2 > 10)
            {
                print(w);
                wait.RemoveAt(0);
                time2 -= 10;
            }
            */
        }
        
        if(time > waitTime)
        {

        }
        //print(waitTime);
    }

    /*
    void Update()
    {
        time += Time.deltaTime;

        startPosition = new Vector3(3.73f, 2.5f, -3.761f);

        if(time > 10)
        {
            moveDirection = new Vector3(1.67f, 2.5f, -3.761f);
            time -= 10;

            if (time > 25)
            {
                if(time > 35)
                {

                }
            }
        }






        if (time > 60){
            if (Vector3.Distance(windowMonster.position, moveDirection) > 0.1f){
                speed = 0.001f;
                if (Vector3.Distance(windowMonster.position, moveDirection) == 0.1f){
                    speed = 0;
                    //if(t.gameTimer > )
                }
            }
            float movement = speed * speedMultiplier;
            windowMonster.position = Vector3.MoveTowards(windowMonster.position, moveDirection, movement);
        }
    }
    */


}
