using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3f;
    public float InitialAngle = 0.67f;
    public float startX = 0f;
    public float maxStartY = 4f;
    public float speedMultiplier = 1.1f;
    void Start()
    {
        InitiaPush();
        GameManager.instance.onReset += ResetBall;
    }
    private void ResetBall()
    {
        ResetBallPosititon();
        InitiaPush();
    }
    public void InitiaPush()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;


        dir.y = Random.Range(-InitialAngle, InitialAngle);
        rb.velocity = dir * speed;
    }

    public void ResetBallPosititon()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        scoreZone scoreZone = collision.GetComponent<scoreZone>();
        if (scoreZone)
        {
            GameManager.instance.OnScoreZoneReached(scoreZone.id);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Paddle paddle = collision.collider.GetComponent<Paddle>();
        if (paddle)
        {
            rb.velocity *= speedMultiplier;
        }
    }
}
