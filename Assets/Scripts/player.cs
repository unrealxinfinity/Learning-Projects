using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    private float moveSpeed = 7;
    private Vector2 leftBound = new Vector2(-9.5f,0);
    private Vector2 rightBound = new Vector2 (9.5f,0);
   
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       
    }
    // Update is called once per frame
    protected void Update()
    {
        leftBound = new Vector2(-9.5f, transform.position.y);
        rightBound = new Vector2(9.5f, transform.position.y);
        if (Input.GetKeyDown("space")) rb.gravityScale *= -1;
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        if ( transform.position.x < -9.5f)
        {
            transform.position = leftBound;

        }
        if ( transform.position.x > 9.5f)
        {
            transform.position = rightBound;
        }
        

     }
    
    }
   
      
    







