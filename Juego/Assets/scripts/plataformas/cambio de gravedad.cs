using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodegravedad : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var normal = other.GetComponent<jugadorsalto>();
        var invertido = other.GetComponent<jugador_salto_invertido>();

        if (normal != null && invertido != null)
        {
            normal.enabled = false;
            invertido.enabled = true;
        
        }
    }
}
