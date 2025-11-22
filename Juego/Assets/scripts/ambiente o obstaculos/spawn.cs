using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnpoints.Instance.ultimoSpawn(gameObject);
            Debug.Log("NUEVO SPAWN GUARDADO: " + gameObject.name);
        }
    }
}
