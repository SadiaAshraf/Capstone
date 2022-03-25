using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroPlayer : MonoBehaviour
{
    float h;
    float v;
    public Vector2 speed = new Vector2(20, 20);
    public int health = 3;

    public GameObject BulletPrefab; //astronaut bullet

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        //  v = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * h, speed.y * v);
        transform.Translate(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab, transform.position, BulletPrefab.transform.rotation);
        }

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector2.left * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
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



     
}
