using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Prefab;
    public float VerticalSpawn = 7;
    public float HorizontalSpawn = 20;
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
        float spawnY = Random.Range(-VerticalSpawn, VerticalSpawn);

        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        return spawnPos;
    }

    void SpawnElements()
    {
        Instantiate(Prefab, SpawnMisiles(), Prefab.transform.rotation);
    }
}
