using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public float jumpForce = 1.0f;
    private bool isGrounded;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 movePlayer = new Vector2(0, 0);


        if (Input.GetKey(KeyCode.A))
        {
            movePlayer.x = -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movePlayer.x = 1f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        rb.MovePosition(movePlayer + rb.position * Time.fixedDeltaTime * playerSpeed);
    }
}
