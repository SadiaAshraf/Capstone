using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector2.up * Time.deltaTime * 12);
        }
       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

           
        }

        
    }
}