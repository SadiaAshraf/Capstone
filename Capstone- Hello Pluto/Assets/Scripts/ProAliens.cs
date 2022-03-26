using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProAliens : Aliens
{
    public GameObject bombPrefab;


    void Start()
    {
        // InvokeRepeating("shoot", 2, 1);

        StartCoroutine("Shooter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public override void Shoot()
    {
        
    }

    IEnumerator Shooter()
    {
        while (true)
        {
            Vector2 pos = new Vector2(transform.position.x -2,transform.position.y);
            yield return new WaitForSeconds(2);
            Instantiate(bombPrefab, pos, bombPrefab.transform.rotation);
            Debug.Log("Bomb is going");
        }
    }
}
