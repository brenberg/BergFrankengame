using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedDistance : MonoBehaviour
{
    public Transform battery;
    public float moveSpeed;
    public GameObject enableLight;
    public GameObject helpText;

    void Update()
    {
        float dist = Vector3.Distance(battery.position, transform.position);
        //print("Distance to other: " + dist);

        if (dist <= 5)
        {
            //Within Range 
            enableLight.SetActive(true);
            helpText.SetActive(false);

            //Movement
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
        if (dist > 5)
        {
            //Out Of Range
            enableLight.SetActive(false);
            helpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                //Reset Pos
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
