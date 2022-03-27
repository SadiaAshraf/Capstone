using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWigAlien : Aliens
{
    Vector2 Pi = new Vector2(62, 0);  //initial and final positions
    //Vector2 Pf = new Vector2(82, 0);
    float sp = 1; //speed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(5f, 0f) * Pi * Time.deltaTime *sp);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("P1"))
        {
            Pi.x *= -1;

        }
        else if (collision.gameObject.CompareTag("P2"))
        {
            Pi.x *= -1;
        }
    }
}
