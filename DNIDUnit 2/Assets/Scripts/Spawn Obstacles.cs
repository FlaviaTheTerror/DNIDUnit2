using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    public float clearPathInterval = 10f; // Time in seconds after which a clear path will be provided
    private float lastClearPathTime = 0f; // Last time a clear path was provided

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            // Check if it's time to provide a clear path
            if (Time.time - lastClearPathTime >= clearPathInterval)
            {
                // Don't spawn obstacles this time to provide a clear path
                lastClearPathTime = Time.time;
            }
            else
            {
                Spawn();
            }
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}