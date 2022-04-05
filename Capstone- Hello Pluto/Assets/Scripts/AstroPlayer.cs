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

    public Animator PlayerAnimator;
    public float moo;

    Vector3 endSize;

    private Vector3 respawnPoint;
    public GameObject Falldetector;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       //  InvokeRepeating("spawningBullets", 1, 1);
       PlayerAnimator = GetComponent<Animator>();   
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        //if( Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector2.left * speed * Time.deltaTime);
        //    moo = 10;
            
        //}
        //else if   (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //    moo = 20;
        //    }
        //else
        //{
        //    moo = 0;
        //}

        h= Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * h, speed.y * v);
        transform.Translate(movement * Time.deltaTime);

        PlayerAnimator.SetFloat("Speed", h);

        if (Input.GetKey(KeyCode.UpArrow) && OnGround)
        {
            //rb.velocity = new Vector2(rb.velocity.x,jumpForce); 
            jump();
        }

        BulletSpawing();






        // endSize = new Vector3(0.25f, 0.25f, 0.25f);
        endSize = new Vector3(0f, 0f, 0f);

        if(GameManager.Elements == 2)
        {
            transform.localScale = new Vector3(0.70f, 0.70f, 0.70f);
        }

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



    }


  
    public void IsGameOver()
    {
        if (health <= 0) 
        {
            Debug.Log("Game Over");
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
       else if  (transform.localScale == endSize)
        {
           // Destroy(gameObject);
            transform.position = respawnPoint;
        }


    }

    void jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        OnGround = false;
        PlayerAnimator.SetBool("OnGround",OnGround);
    }

    void BulletSpawing()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            Instantiate(BulletPrefab, pos, BulletPrefab.transform.rotation);
            //Instantiate(BulletPrefab);




            //if(GameManager.Elements != 2)
            //{
            //    Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            //    Instantiate(BulletPrefab, pos, BulletPrefab.transform.rotation);
            //    //Instantiate(BulletPrefab);
            //}
            //else
            //{

            //    Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            //    Instantiate(BulletPrefab, pos, BulletPrefab.transform.rotation(0,-45,0);
            //    //Instantiate(BulletPrefab);
            //}

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="ChotaAlien" || collision.gameObject.CompareTag("Spikes") )
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
        else if (collision.gameObject.CompareTag("Element"))
        {
            GameManager.Elements = GameManager.Elements + 1;
            Debug.Log("Eelement Collected " + GameManager.Elements);
            Debug.Log("Eelement Collected");
            collision.gameObject.SetActive(false);
        }
       

    }

}
