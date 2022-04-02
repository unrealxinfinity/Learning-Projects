using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathTrigger : MonoBehaviour
{
    float cur_frame_duration = 0;
    [SerializeField]
    float frame_duration = 2f;
    [SerializeField]
    float health = 100f;
    private Vector2 resetPos = new Vector2(-7.6f, -2f);
    void Update()
    {
        cur_frame_duration -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (health <= 0)
        {
            Debug.LogWarning("Game Over");
            return;
        }
        if (other.gameObject.CompareTag("obstacle") && cur_frame_duration<=0)
        {
            cur_frame_duration = frame_duration;
            health -= 25;
            gameObject.transform.position = resetPos;
        }
    }
}
