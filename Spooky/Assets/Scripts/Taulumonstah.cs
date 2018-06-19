using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taulumonstah : MonoBehaviour {

    public GameObject target;


	// Use this for initialization
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetDirection = target.transform.position - transform.position;
        Quaternion currentRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * 180);
    }
}
