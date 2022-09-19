using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeDeplete : MonoBehaviour
{
    public static bool charging;

    // Start is called before the first frame update
    void Start()
    {
        charging = false;
    }

    // Update is called once per frame
    void Update()
    {
        //On collision
        //Get tag
        //charge
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charger"))
        {
            charging = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charger"))
        {
            charging = false;
        }
    }
}
