using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
    }
}
