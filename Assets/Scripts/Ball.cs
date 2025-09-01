using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ball;
    public float moveSpeed = 5;
    private Vector2 _lastDirection = new(-1f, -1f);

    void Start()
    {
        ball.linearVelocity = _lastDirection.normalized * moveSpeed;
    }
    void Update()
    {
        ball.linearVelocity = _lastDirection.normalized * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 direction = collision.contacts[0].normal;
        _lastDirection = Vector2.Reflect(_lastDirection, direction);
    }
}