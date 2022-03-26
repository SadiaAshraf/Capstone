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
            yield return new WaitForSeconds(2);
            Instantiate(bombPrefab, transform.position, bombPrefab.transform.rotation);
            Debug.Log("Bomb is going");
        }
    }
}
