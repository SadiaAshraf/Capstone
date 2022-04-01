using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBounds : MonoBehaviour
{
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x > 120) 
        //{
        //    Destroy(gameObject);
        //}
        //else if (transform.position.x > -20) 
        //{
        //    Destroy(gameObject);
        //}

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("P1"))
        {
            Destroy(gameObject);
        }
    }
}
