using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeDeplete : MonoBehaviour
{
    public static bool charging;
    public static bool damage;

    void Start()
    {
        charging = false;
        damage = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charger"))
        {
            charging = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            damage = true;
        }

        if (collision.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charger"))
        {
            charging = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            damage = false;
        }
    }
}
