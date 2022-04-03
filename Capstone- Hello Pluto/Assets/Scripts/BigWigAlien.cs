using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWigAlien : Aliens
{
    private int speed = 15;
    private bool right = true;
    private int movement = 1;
    public bool gameOver = false;

    float health = 17;
    void Start()
    {
        
    }

    // Update is called once per frame
    IEnumerator DirectionChanger()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(0.1f);
            if (right)
            {
                right = false;
                movement = 1;
                Debug.Log("right false");
            }
            else
            {
               right = true;
                movement = -1;
                Debug.Log("right true");
            }

        }
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * movement);

        //transform.forward *= speed;
        DirectionChanger();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
