using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnRadius = 5f;
    public float spawnInterval = 1f;
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
            Instantiate(cubePrefab, spawnPos, Quaternion.identity);
            nextSpawnTime = Time.time + spawnInterval;           
        }
    }
}
