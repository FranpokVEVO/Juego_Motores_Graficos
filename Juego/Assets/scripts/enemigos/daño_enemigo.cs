using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daño_enemigo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadormorir vida = other.GetComponent<jugadormorir>();

            if (vida != null)
            {
                vida.Morir();
            }
        }
    }
}
