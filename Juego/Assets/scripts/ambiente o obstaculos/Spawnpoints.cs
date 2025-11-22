using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnpoints : MonoBehaviour
{
    public static spawnpoints Instance;

    private GameObject[] spawnpoint;
    [SerializeField] private GameObject jugador;

    private int inicioSpawnPoint;

    private void Awake()
    {
        Instance = this;

        spawnpoint = GameObject.FindGameObjectsWithTag("Spawnpoint");

        inicioSpawnPoint = PlayerPrefs.GetInt("SpawnInicial", 0);

        
        if (inicioSpawnPoint < 0 || inicioSpawnPoint >= spawnpoint.Length)
        {
            inicioSpawnPoint = 0;
        }

        Instantiate(jugador, spawnpoint[inicioSpawnPoint].transform.position, Quaternion.identity);
    }

    public void ultimoSpawn(GameObject spawn)
    {
        for (int i = 0; i < spawnpoint.Length; i++)
        {
            if (spawnpoint[i] == spawn)
            {
                PlayerPrefs.SetInt("SpawnInicial", i);
                PlayerPrefs.Save();
                Debug.Log("GUARDADO SPAWN: " + i);
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