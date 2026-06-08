using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2f;
    public float id;

    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxisRaw("MovePlayer1");
                break;
            case 2:
                movement = Input.GetAxisRaw("MovePlayer2");
                break;
        }
        return movement;
    }

    private void Move(float movement)
    {
        Vector2 velo = rb.velocity;
        velo.y = movement * speed;
        rb.velocity = velo;
    }
}
