using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar_check1 : MonoBehaviour
{
    public GameObject spawnpoint2; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnpoint2.SetActive(true);
        }
    }
}
