using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterController : MonoBehaviour
{
    public float dir; 
    public float speed = 14f;

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (isPlayer)
            spriteRenderer.color = SaveControler.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveControler.Instance.colorEnemy;

    }
    void Update()
    {
        move();
    }
    void move()
    {
        dir = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(0, dir * speed);
    } 

}
