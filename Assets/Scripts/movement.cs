using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float speed = 7;
    Vector2 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x <= -9.5f)
        {
            gameObject.transform.position  =  originalPos;
        }
    }
}
