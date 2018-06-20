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
    public int startToMove = 10;
    public Transform door1;
    public Transform door2;

    private void Start()
    {
        startingPosition = transform.position;
        door1 = GameObject.Find("Sarana").GetComponent<Transform>();
        door2 = GameObject.Find("SaranaKaksi").GetComponent<Transform>();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > startToMove)
        {
            if (Vector3.Distance(closetMonster.position, moveDirection) > 0.1f)
            {
                speed = 0.001f;
                door1.Rotate(new Vector3(0, 0.05f, 0), Space.Self);
                door2.Rotate(new Vector3(0, -0.05f, 0), Space.Self);
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
            startToMove -= 1;
        }
    }
}
