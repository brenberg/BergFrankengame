using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryLevel : MonoBehaviour
{
    public float changeRate;

    void Update()
    {
        if (ChargeDeplete.charging && transform.localScale.y < 1)
        {
            //Charging
            changeRate = 0.08f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + changeRate * Time.deltaTime, transform.localScale.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y + changeRate/2, transform.position.z);
        }
        if (ChargeDeplete.damage && transform.localScale.y > 0)
        {
            Debug.Log("Damage");
            changeRate = 5f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - changeRate * Time.deltaTime, transform.localScale.z);

        }
        else if (transform.localScale.y > 0 && !ChargeDeplete.damage && !ChargeDeplete.charging)
        {
            //Natural Deplete
            changeRate = 0.03f;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - changeRate * Time.deltaTime, transform.localScale.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y - changeRate / 2, transform.position.z);
        }
    }
}
