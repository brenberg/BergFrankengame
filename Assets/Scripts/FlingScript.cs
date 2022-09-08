using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows the user to click on the square, drag, and release to fling
public class FlingScript : MonoBehaviour
{
    public IntVariable flingNum;
    public FloatVariable flingStrength;
    Rigidbody2D rb;
    Vector2 mouseUpPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseUp()
    {
        // get mouse position in world coordinates
        mouseUpPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // difference vector
        Vector2 diff = (Vector2)transform.position - mouseUpPos;
        diff = diff.normalized * Mathf.Clamp(diff.magnitude, 0.5f, 2f);

        // add that force with speed
        rb.AddForce(diff * flingStrength.value);

        // increment int var
        flingNum.value++;
    }
}
