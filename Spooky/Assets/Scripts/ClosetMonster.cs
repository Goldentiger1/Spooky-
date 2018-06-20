using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetMonster : MonoBehaviour
{

    private float time;
    public Transform closetMonster;
    public Vector3 moveDirection;
    public float speed;
    private float speedMultiplier = 1f;
    public Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > 10)
        {
            if (Vector3.Distance(closetMonster.position, moveDirection) > 0.1f)
            {
                speed = 0.001f;
                if (Vector3.Distance(closetMonster.position, moveDirection) == 0.1f)
                {
                    speed = 0;
                }
            }
            float movement = speed * speedMultiplier;
            closetMonster.position = Vector3.MoveTowards(closetMonster.position, moveDirection, movement);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "InteractableObjects")
        {
            transform.position = startingPosition;
            time = 0;
        }
    }
}
