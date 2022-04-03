using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float h;
    float v;
    public Vector2 speed = new Vector2(20, 20);
    public int health =3;

    public GameObject projectilePrefab; // bulletprefab

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }



    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("NextLevel"))
    //    {
    //       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //        Debug.Log("Next level 1 ");
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Next level trigger ");

        }
    }
}
