using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityObject : basicObstacle
{
    // Start is called before the first frame update
    protected void reverseGravity()
    {
        rb.gravityScale *= -1;
    }
    protected virtual void Update()
    {
        if (Input.GetKeyDown("space")) reverseGravity();
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if(collision.gameObject.tag=="wall")
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y * (-1f) * 0.9f, 0f);
        }
    }
}
