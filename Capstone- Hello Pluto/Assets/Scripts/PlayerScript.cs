using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float h;
    float v;
    public Vector2 speed = new Vector2(20, 20);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  transform.Translate(Vector2.up * Time.deltaTime * 10);
        h = Input.GetAxis("Horizontal");

        v = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * h, speed.y * v);
        transform.Translate(movement * Time.deltaTime);
    }
}
