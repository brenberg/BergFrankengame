using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedDistance : MonoBehaviour
{
    public Transform battery;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(battery.position, transform.position);
        //print("Distance to other: " + dist);

        if (dist <= 5)
        {
            //Within Range 

            //color change

            //Movement
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
            }
        }

        if (dist > 5)
        {
            //Out Of Range

            //color change

            if (Input.GetKey(KeyCode.E))
            {
                //Reset Pos

                //Need Prompt

                transform.position = new Vector3(battery.position.x, battery.position.y + 2, transform.position.z);
            }
            if (transform.position.y > battery.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
            }
            if (transform.position.y < battery.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            }
            if (transform.position.x > battery.position.x)
            {
                transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            }
            if (transform.position.x > battery.position.x)
            {
                transform.position = new Vector3(transform.position.x +0.1f, transform.position.y, transform.position.z);
            }
        }
    }
}
