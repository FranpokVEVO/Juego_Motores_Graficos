using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemigos : MonoBehaviour
{
public GameObject enemyPrefab;
    public Transform spawner;

    public float intervalo1 = 2f; 
    public float intervalo2 = 4f; 

    public float yMin = -3f;   
    public float yMax = 3f;   

    private float timer = 0f;
    private bool usarIntervalo1 = true;

    void Update()
    {
        timer += Time.deltaTime;

        float intervaloActual = usarIntervalo1 ? intervalo1 : intervalo2;

        if (timer >= intervaloActual)
        {
            timer = 0f;

            float yRandom = Random.Range(yMin, yMax);

            Vector3 spawnPos = new Vector3(spawner.position.x, yRandom, spawner.position.z);

            Instantiate(enemyPrefab, spawnPos, Quaternion.Euler(0f, 90f, 0f));

            usarIntervalo1 = !usarIntervalo1;
        }
    }
}
