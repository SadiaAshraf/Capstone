using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Prefab; //enemyPrefab
    //public float VerticalSpawn = 7;
    public float HorizontalSpawn = 5;

   // public GameObject EnemyPrefab;

    public MisileController MyMisileController;

 
    void Start()
    {
        InvokeRepeating("SpawnElements",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 SpawnMisiles()
    {
        float spawnX = Random.Range(-HorizontalSpawn, HorizontalSpawn);
        float spawnY = Random.Range(3, 5);

        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        return spawnPos;
    }

    void SpawnElements()
    {
       if (!MyMisileController.IsGameOver)
        {
            Debug.Log("" + !MyMisileController.IsGameOver);
            Instantiate(Prefab, SpawnMisiles(), Prefab.transform.rotation);
        }
       
    }
}
