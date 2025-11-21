using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnobstaculos : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; 
    public Transform Player;
    public float spawnInterval = 2f;

    public float spawnX = 18f;
    public float posY1 = 0f;
    public float posY2 = 12f;

    private float timer = 0f;

    void Update()
    {
        if (Player == null) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

      
            int index = Random.Range(0, obstaclePrefabs.Length);

            float selectedY = (index == 0) ? posY1 : posY2;

            Vector3 spawnPos = new Vector3(Player.position.x + spawnX, selectedY, Player.position.z);

            Instantiate(obstaclePrefabs[index], spawnPos, Quaternion.identity);
        }
    }
}

