using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBounds : MonoBehaviour
{
    public Vector2 leftSide = new Vector2 (20,5);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > 20) || (transform.position.y > 5))
        {
            Destroy(gameObject);
        }
        else if ((transform.position.x > -20) || (transform.position.y < -3))
        {
            Destroy(gameObject);
        }

       
    }
}
