using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemigos : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawner; 
    public float spawnInterval = 3f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
          timer = 0f;

          Instantiate(enemyPrefab, spawner.position, Quaternion.Euler(0f, 90f, 0f));
        }
    }
}
