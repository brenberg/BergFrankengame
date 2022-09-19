using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryLevel : MonoBehaviour
{
    //public Transform battery;
    public float changeRate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ChargeDeplete.charging && transform.localScale.y < 1)
        {
            //Charging
            changeRate = 0.001f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + changeRate, transform.localScale.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y + changeRate/2, transform.position.z);
        }
        if (!ChargeDeplete.charging && transform.localScale.y > 0)
        {
            //Depleting
            changeRate = 0.001f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - changeRate, transform.localScale.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y - changeRate/2, transform.position.z);
        }
        else if (transform.localScale.y > 0)
        {
            //Natural Deplete
            changeRate = 0.0005f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - changeRate, transform.localScale.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y - changeRate / 2, transform.position.z);
        }
    }
}
