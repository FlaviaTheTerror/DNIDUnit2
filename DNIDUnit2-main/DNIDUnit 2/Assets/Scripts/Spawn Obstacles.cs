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
    public float safePathWidth = 4f; // Width of the safe path in the middle
    public float middleOffset = 0f; // Use this if your player doesn't start exactly in the middle

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        float middleX = (minX + maxX) / 2 + middleOffset; // Middle point of the road adjusted for offset
        // Check if the randomX is within the middle safe path, adjust if necessary
        if (randomX > middleX - safePathWidth / 2 && randomX < middleX + safePathWidth / 2)
        {
            // The obstacle is about to spawn in the safe path, so we relocate it
            // Decide randomly to move it left or right
            if (Random.value > 0.5f)
            {
                randomX = Mathf.Max(randomX - safePathWidth, minX); // Move to the left
            }
            else
            {
                randomX = Mathf.Min(randomX + safePathWidth, maxX); // Move to the right
            }
        }

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
