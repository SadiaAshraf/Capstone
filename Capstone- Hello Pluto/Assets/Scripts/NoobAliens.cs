using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoobAliens : Aliens
{
    float speed = 1f;
    Rigidbody2D rb;
    Vector2 directionObj = new Vector2(1, 0);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.Translate(transform.forward * speed * Time.deltaTime);
        // rb.velocity = new Vector2( speed * Time.deltaTime, 0);
        // transform.rotation= 180,0)
        transform.Translate(new Vector2(5f, 0f) * directionObj * Time.deltaTime);
        


    }

    override public void jump()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Obstacle")) || (collision.gameObject.CompareTag("Player")) ||  (collision.gameObject.CompareTag("Enemy")) || (collision.gameObject.CompareTag("P1")))
        {
            directionObj.x *= -1;
            Debug.Log("collision with walls or player detacted");
            
        }
    }
}
