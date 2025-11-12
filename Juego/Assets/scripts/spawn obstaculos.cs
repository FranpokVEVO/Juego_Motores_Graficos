using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobstaculos : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform Player;
    public float spawnInterval = 2f;
    public float spawnX = 40f;
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
            float randomY = Random.value > 0.4f ? posY1 : posY2;

            Vector3 spawnPos = new Vector3(Player.position.x + spawnX, randomY, Player.position.z);

            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        }
    }

}
