using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroPlayer : MonoBehaviour
{
    float h;
    float v;
    public Vector2 speed = new Vector2(20, 20);
    public int health = 3;
    float jumpForce = 5f;

    Rigidbody2D rb;

    public GameObject BulletPrefab; //astronaut bullet

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       //  InvokeRepeating("spawningBullets", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        //  v = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * h, speed.y * v);
        transform.Translate(movement * Time.deltaTime);

        BulletSpawing();
       

       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            jump(); 
        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "ChotaAlien")
        {
            health -= 1;
            Debug.Log("Health = " + health);
            IsGameOver();
        }
    }

    public void IsGameOver()
    {
        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    void jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

   void BulletSpawing()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y+1);
            Instantiate(BulletPrefab, pos, BulletPrefab.transform.rotation);
            //Instantiate(BulletPrefab);
        }
    }
     
}
