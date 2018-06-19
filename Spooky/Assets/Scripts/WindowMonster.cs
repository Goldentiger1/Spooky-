using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMonster : MonoBehaviour {
    public float speed;
    private float speedMultiplier = 1f;
    private Transform windowMonster;
    public List<Vector3> waypoints; 
    public Vector3 startPosition;
    public float time;
    public float wait;

    void Start()
    {
        windowMonster = GameObject.Find("FirstEnemy").transform;
        wait = 60;
        //waypoints.Add()
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > wait)
        {
            time -= wait;
            wait = 15;
        }
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
