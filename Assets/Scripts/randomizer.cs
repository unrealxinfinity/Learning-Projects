using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public basicObstacle[] baseObjects;
    float timer = 0f, totalTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            timer -= 5f;
            GameObject obstacle = GameObject.Instantiate(baseObjects[Random.Range(0, baseObjects.Length)].gameObject);
            obstacle.GetComponent<basicObstacle>().tempObject(10f, 2.5f);
        }
    }
}
