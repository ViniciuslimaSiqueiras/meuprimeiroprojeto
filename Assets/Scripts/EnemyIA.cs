using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    public Transform ball;
    public int velocity;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        var dir = new Vector3(transform.position.x, ball.position.y, transform.position.z);
        dir.y = Math.Clamp(dir.y, -9, 9);
        transform.position = Vector3.MoveTowards(transform.position, dir, 1 * velocity * Time.deltaTime);
    }
}
