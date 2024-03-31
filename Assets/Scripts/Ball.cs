using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startVelocity = new Vector2(8,8);
    public Vector2 _currentVelocity;
    public Vector2 dir;
    public GameManager gm;

    public Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = startVelocity;
    }
    void Update()
    {
        dir = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            dir.y = dir.y * -1;
            rb.velocity = dir;
        }
        if (collision.gameObject.CompareTag("Jogador"))
        {
            dir.x = dir.x * -1;
            dir *= 1.3f;
            rb.velocity = dir;

        }
        if (collision.gameObject.CompareTag("PlayerPointer"))
        {
            gm.SetEnemyPoint(1);
            rb.velocity = startVelocity;
            gm.ResetBall();
        }
        if (collision.gameObject.CompareTag("EnemyPointer"))
        {
            gm.SetPlayerPoint(1);
            rb.velocity = startVelocity;
            gm.ResetBall();
        }
    }

}
