using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceMovementScript : MonoBehaviour
{
    private Rigidbody2D body;
    public Animator anim;

    private float horizontal;
    private float vertical;

    private const int moveSpeed = 8;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        // Gives a value between -1 and 1
        //accepts input only if the character is static
        if (vertical == 0 && body.velocity == Vector2.zero)
        {
            horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        }

        if (horizontal == 0 && body.velocity == Vector2.zero)
        {
            vertical = Input.GetAxisRaw("Vertical"); // -1 is down
        }

        Move();

        if(body.velocity == Vector2.zero)
        {
            anim.SetFloat("speed", 0);
        }
    }

    //moves character constantly until a collision
    private void Move()
    {
        if (horizontal == 1)//move right
        {
            body.velocity = new Vector2(moveSpeed, 0);
            anim.SetFloat("speed", 8);
        }

        if (horizontal == -1)//move left
        {
            body.velocity = new Vector2(-moveSpeed, 0);
            anim.SetFloat("speed", 8);
        }

        if (vertical == 1)//move up
        {
            body.velocity = new Vector2(0, moveSpeed);
            anim.SetFloat("speed", 8);
        }

        if (vertical == -1)//move down
        {
            body.velocity = new Vector2(0, -moveSpeed);
            anim.SetFloat("speed", 8);
        }

    }
}
