using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spikes : MonoBehaviour
{
    float speed = 5f;
    bool FloatingUp = false;
    void Start()
    {
        transform.Translate(Vector2.down * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (FloatingUp)
        {
           
        }
    }

    //void floatdown()
    //{
       
    //    transform.position.y -= 0.5 * speed * Time.deltaTime;
    //    yield return new WaitForSeconds(1);

    //}
}
