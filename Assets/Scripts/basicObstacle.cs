using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicObstacle : MonoBehaviour
{
    public float[] possiblePositions;
    public Transform position;
    public Rigidbody2D rb;
    public virtual IEnumerator destroyTimer(float timer, float moveSpeed)
    {
        while (timer >= 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }
        Destroy(this.gameObject);
    }
    public virtual void tempObject(float timer, float moveSpeed)
    {
        rb.velocity = new Vector3(-moveSpeed, 0, 0);
        position.position = new Vector3(10f, possiblePositions[Random.Range(0, possiblePositions.Length)], 0);
        StartCoroutine(destroyTimer(timer, moveSpeed));
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision) //USE ONCOLLISIONENTER IF YOU DISABLE THE TRIGGER OPTION
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.LogWarning("HIT");
            //DEATH
            //TODO
        }
    }
    protected virtual void Start()
    {
        position = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }
}
