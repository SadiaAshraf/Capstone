using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroPlayer : MonoBehaviour
{
    float h;
    float v;
    public Vector2 speed = new Vector2(20, 20);
    public int health = 3;
    float jumpForce =2.5f;

    Rigidbody2D rb;
    bool OnGround = true;
    public GameObject BulletPrefab; //astronaut bullet

    private Animator PlayerAnimator;

    Vector3 endSize;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       //  InvokeRepeating("spawningBullets", 1, 1);
       PlayerAnimator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        v = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * h, speed.y * v);
        transform.Translate(movement * Time.deltaTime);

        //if (h > 0 || h < 0)
        //{
        //    PlayerAnimator.SetBool("isWalk", true);
        //    rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        //    rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        //}
        //else
        //{
        //    PlayerAnimator.SetBool("isWalk", false);
        //    rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        //    rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        //}


        BulletSpawing();
       

       
        if (Input.GetKey(KeyCode.UpArrow) && OnGround )
        {
            //rb.velocity = new Vector2(rb.velocity.x,jumpForce); 
            jump();
        }

        // endSize = new Vector3(0.25f, 0.25f, 0.25f);
       // endSize = new Vector3(0f, 0f, 0f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "ChotaAlien")
        {
            health -= 1;
            Debug.Log("Health = " + health);
            transform.localScale -= new Vector3(0.25f, 0.25f, 0.25f);
            Debug.Log("Collison with chota alien");
            IsGameOver();


        }

       if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }

        if (collision.gameObject.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Next level ");
        }

        else if (collision.gameObject.CompareTag("Coin"))
        {
            GameManager.Score += 1;
            Debug.Log("Scores = " + GameManager.Score);
            collision.gameObject.SetActive(false);
        }
    }

    public void IsGameOver()
    {
        if (health <= 0) 
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        //if ((health <= 0) || (transform.localScale == endSize))
        //{
        //    Debug.Log("Game Over");
        //    Destroy(gameObject);
        //}


    }

    void jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        OnGround = false;
    }

    void BulletSpawing()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            Instantiate(BulletPrefab, pos, BulletPrefab.transform.rotation);
            //Instantiate(BulletPrefab);
        }
    }
     
}
