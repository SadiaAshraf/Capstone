using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MisileController : MonoBehaviour
{
    public float speed = 3f;
   
    public GameObject player;
    private Rigidbody2D EnemyRb;
    public bool IsPlayerAlive = true;
    public bool IsGameOver = false;
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody2D>();
       // player = GameObject.Find("Player");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        movement();
       
        // transform.Translate(Vector2.up * Time.deltaTime * speed);

        //if (transform.position.x > 20)
        //{
        //    //transform.Translate(Vector2.right);
        //}
        //else if (transform.position.x > -20)
        //{
        //    transform.Translate(Vector2.left);
        //}

        //else if (transform.position.y > 8)
        //{
        //    transform.Translate(Vector2.down);
        //}
        //else if (transform.position.y < -7)
        //{
        //    transform.Translate(Vector2.up);
        //}

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsPlayerAlive = false;
            IsGameOver = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
           
        }
        
    }

    public void  movement()
    {
        if (player != null)
        {
            Vector2 LookDirection = (player.transform.position - transform.position).normalized;
            EnemyRb.AddForce(LookDirection * speed);
           
        }

    }

}
