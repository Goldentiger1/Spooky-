using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour {

    public Vector3 distance = new Vector3(1f, 2f, 1f);
    public Vector3 objDistance;
    public Light lightbulbLight;
    public float originPos;
    public float triggerDistance;

    private void Start()
    {
        lightbulbLight = GameObject.Find("Sphere").GetComponent<Light>();
        originPos = transform.position.y;
    }


    void Update()
    {
//        objDistance = GameObject.Find("Sphere.001").GetComponent<Transform>().position;
        
        if(transform.position.y < originPos - triggerDistance)
        {
            lightbulbLight.enabled = true; //!enabled;
        }
    }

}
