using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemigos : MonoBehaviour
{
 public GameObject[] enemyPrefabs;
    public Transform player;
    public float spawnInterval = 3f;
    public float spawnDistance = 18f;

    private float timer = 0f;

    void Update()
    {
        if (player == null) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            int index = Random.Range(0, enemyPrefabs.Length);

            Vector3 spawnPos = new Vector3(player.position.x + spawnDistance, 0f, 0f);

            Instantiate(enemyPrefabs[index], spawnPos, Quaternion.identity);
        }
    }
}
