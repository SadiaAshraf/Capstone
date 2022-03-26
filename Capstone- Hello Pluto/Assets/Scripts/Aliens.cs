using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public int alienHealth;

    
    //public Transform Pos;
    void Start()
    {
        
       // Shoot();
    }

    // Update is called once per frame
    void Update()
    {
       
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

    public virtual void Shoot()
    {
        //Instantiate(bombPrefab);
       
    }
}
