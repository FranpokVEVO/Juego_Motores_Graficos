using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar_check2 : MonoBehaviour
{
     public GameObject spawnpoint3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnpoint3.SetActive(true);
        }
    }
}
