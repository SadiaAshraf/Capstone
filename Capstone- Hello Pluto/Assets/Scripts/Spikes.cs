using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    float speed = 5f;
    void Start()
    {
        transform.Translate(Vector2.down * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < -3.5)
        {
            transform.Translate(Vector2.up * speed);
        }
    }
}
