using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBombs : MonoBehaviour
{
    float speed = 5f;
    AstroPlayer player;
    void Start()
    {
       player = GameObject.Find("AstroStay").GetComponent<AstroPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            player.health -= 1;
            Debug.Log("Health = " + player.health);
            Debug.Log("Alien bombs are working" );
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
