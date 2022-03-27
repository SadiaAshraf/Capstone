using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spikes : MonoBehaviour
{
    float speed = 5f;
    bool FloatingUp = false;

    AstroPlayer player;

    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector2 posOffset = new Vector2();
    Vector2 tempPos = new Vector2();
    void Start()
    {
       // transform.Translate(Vector2.down * speed);
        player = GameObject.Find("AstroStay").GetComponent<AstroPlayer>();
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(transform.position.x , transform.position.y +3);
        tempPos = posOffset + pos;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;



        //if (transform.position.y <= 3)
        // {
        //     transform.position += transform.up * speed * Time.deltaTime;
        // }
        //else if (transform.position.y >= 5)
        // {
        //     transform.position -= transform.up * speed * Time.deltaTime;
        // }

        //while ((transform.position.y > 2) && (transform.position.y < 5) )
        // {
        //     transform.position += transform.up * speed * Time.deltaTime;
        // }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "AstroStay")
        {
            player.health -= 2;
        }
    }
}
