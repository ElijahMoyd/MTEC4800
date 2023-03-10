using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f; // speed of movement
    public float jumpForce = 10.0f; // force of jump

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get Rigidbody2D component
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // get horizontal input
        float moveVertical = Input.GetAxis("Vertical"); // get vertical input

        Vector2 movement = new Vector2(moveHorizontal, moveVertical); // create movement vector
        rb.velocity = new Vector2(movement.x * speed, movement.y * speed); // apply movement velocity

        if (Input.GetKeyDown(KeyCode.Space)) // check for jump input
        {
            rb.AddForce(new Vector2(0.0f, jumpForce), ForceMode2D.Impulse); // apply jump force
        }
    }
}