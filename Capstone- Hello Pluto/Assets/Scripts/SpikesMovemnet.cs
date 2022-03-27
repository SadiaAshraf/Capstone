using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesMovemnet : MonoBehaviour
{
    private int speed = 5;
    private bool down = true;
    private int movement = 1;
    public bool gameOver = false;

    AstroPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DirectionChanger());
        player = GameObject.Find("AstroStay").GetComponent<AstroPlayer>();
    }


    IEnumerator DirectionChanger()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(1.5f);
            if (down)
            {
                down = false;
                movement = -1;
            }
            else
            {
                down = true;
                movement = 1;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.down * speed * Time.deltaTime * movement);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.health -= 2;
            Debug.Log("Health - spike "+player.health);
            Debug.Log("Spike collided " );
        }
    }
}
