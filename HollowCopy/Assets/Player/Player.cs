using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 movePlayer = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            movePlayer.y += 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movePlayer.y -= 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movePlayer.x += 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movePlayer.x -= 1f;
        }

        
    }
}
