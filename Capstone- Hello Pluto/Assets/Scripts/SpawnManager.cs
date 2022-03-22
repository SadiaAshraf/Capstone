using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Prefab; //enemyPrefab
    //public float VerticalSpawn = 7;
    public float HorizontalSpawn = 20;

   // public GameObject EnemyPrefab;

    public MisileController MyMisileController;

 
    void Start()
    {
        InvokeRepeating("SpawnElements", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 SpawnMisiles()
    {
        float spawnX = Random.Range(-HorizontalSpawn, HorizontalSpawn);
        float spawnY = Random.Range(0, 5);

        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        return spawnPos;
    }

    void SpawnElements()
    {
       if (MyMisileController.IsGameOver == true)
        {
            Instantiate(Prefab, SpawnMisiles(), Prefab.transform.rotation);
        }
       
    }
}
