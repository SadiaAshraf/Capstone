using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileController : MonoBehaviour
{
    public float speed = 3f;
   
    private GameObject player;
    private Rigidbody2D EnemyRb;
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 LookDirection = (player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(LookDirection * speed);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
}
