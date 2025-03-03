using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle; 
    public Vector3 spawnAreaSize = new Vector3(10f, 1f, 10f); 
    public Vector3 spawnAreaCenter = Vector3.zero; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        if (obstacle != null)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnAreaCenter.x - spawnAreaSize.x / 2, spawnAreaCenter.x + spawnAreaSize.x / 2), 1f,
                Random.Range(spawnAreaCenter.z - spawnAreaSize.z / 2, spawnAreaCenter.z + spawnAreaSize.z / 2)
            );
            Instantiate(obstacle, randomPosition, Quaternion.identity);
        }
    }
}
