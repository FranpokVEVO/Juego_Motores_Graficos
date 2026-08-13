using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cambio_De_Gravedad mov = other.GetComponent<Cambio_De_Gravedad>();
            jugadorsalto salto = other.GetComponent<jugadorsalto>();
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (mov != null) mov.enabled = false;
            if (salto != null) salto.enabled = true;
            if (rb != null) rb.useGravity = true;
        }
        if (other.CompareTag("Spawner1"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
