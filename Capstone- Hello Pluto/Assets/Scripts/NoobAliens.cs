using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoobAliens : Aliens
{
    float speed = 50f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.Translate(transform.forward * speed * Time.deltaTime);
        rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        //transform.Translate(Vector2.left * speed * Time.deltaTime);
        jump();

        
    }
    
    override public void jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.down);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Debug.Log("collision pwith player detacted");
            Destroy(gameObject);
        }
    }
}
