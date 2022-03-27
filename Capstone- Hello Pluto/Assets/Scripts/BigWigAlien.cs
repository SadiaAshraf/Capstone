using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWigAlien : Aliens
{
    private int speed = 5;
    private bool right = true;
    private int movement = 1;
    public bool gameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    IEnumerator DirectionChanger()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(0.5f);
            if (right)
            {
                right = false;
                movement = -1;
                Debug.Log("right false");
            }
            else
            {
               right = true;
                movement = 1;
                Debug.Log("right true");
            }

        }
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * movement);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("P1"))
        //{
        //    Pi.x *= -1;

        //}
        //else if (collision.gameObject.CompareTag("P2"))
        //{
        //    Pi.x *= -1;
        //}
    }
}
