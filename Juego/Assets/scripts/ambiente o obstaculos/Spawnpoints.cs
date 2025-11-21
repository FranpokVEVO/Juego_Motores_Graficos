using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnpoints : MonoBehaviour
{
public static spawnpoints Instance;
[SerializeField] private GameObject[] spawnpoint;
[SerializeField] private GameObject jugador;

private int inicioSpawnPoint;

    private void Awake()
    {
        Instance = this;
        spawnpoint = GameObject.FindGameObjectsWithTag("Spawnpoint");
        inicioSpawnPoint = PlayerPrefs.GetInt("SpawnInicial");
        Instantiate(jugador, spawnpoint[inicioSpawnPoint].transform.position, Quaternion.identity);

    }
public void ultimoSpawn (GameObject spawn)
    {
        for (int i = 0; i < spawnpoint.Length; i++)
        {
            if (spawnpoint[i]== spawn)
            {
                PlayerPrefs.SetInt("SpawnInicial", i);
            }
        }
    }

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
