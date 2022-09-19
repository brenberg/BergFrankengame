using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;
    public Transform battery;
    public GameObject gameOverText;
    public GameObject retryButton;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        gameOverText.SetActive(false);
        retryButton.SetActive(false);
        t = 0;
    }

    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        float dist = Vector3.Distance(battery.position, transform.position);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Input.GetKey(KeyCode.Space) && canFire && dist <= 5)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }

        if(battery.localScale.y <= 0.01f)
        {
            t += Time.deltaTime;
            if (t > 4)
            {
                gameOverText.SetActive(true);
                retryButton.SetActive(true);
                Destroy(gameObject);
            }  
        }
    }
}
