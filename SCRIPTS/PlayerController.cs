using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f; 
    public Vector2 movement;           
    public Rigidbody2D rigidbody;
    public Animator anim;
    bool facingRight = true;
    float moveDirection = 0;
    Transform t;
    public float hf = 0.0f;
    public float vf = 0.0f;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        t = transform;
        facingRight = t.localScale.x > 0;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        hf = movement.x > 0.01f ? movement.x : movement.x < -0.01f ? 1 : 0;
        vf = movement.y > 0.01f ? movement.y : movement.y < -0.01f ? 1 : 0;
        if (movement.x < -0.01f)
        {
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetFloat("xspeed", hf);
        anim.SetFloat("yspeed", movement.y);
        anim.SetFloat("speed", vf);

        if (moveDirection != 0)
        {
            if (moveDirection > 0 && !facingRight)
            {
                facingRight = true;
                t.localScale = new Vector3(Mathf.Abs(t.localScale.x), t.localScale.y, transform.localScale.z);
            }
            if (moveDirection < 0 && facingRight)
            {
                facingRight = false;
                t.localScale = new Vector3(-Mathf.Abs(t.localScale.x), t.localScale.y, t.localScale.z);
            }
        }
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
