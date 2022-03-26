using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public int alienHealth;

    public GameObject bombPrefab;
    void Start()
    {
        InvokeRepeating("shoot", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

   virtual public void jump()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Bullet collided with alien");
            Destroy(gameObject);

        }


    }

   virtual public void Shoot()
    {
        Instantiate(bombPrefab);
    }
}
