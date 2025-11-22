using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject ataquePrefab; 
    public float spawnInterval = 2f; 

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnAtaque();
        }
    }

    void SpawnAtaque()
    {
        Instantiate(ataquePrefab, transform.position, Quaternion.identity);
    }
}
