using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimnar : MonoBehaviour
{
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("BALA") || other.CompareTag("Obstaculos") || other.CompareTag("Enemy") || other.CompareTag("Ataque"))
    {
        Destroy(other.gameObject);
    }
}
}
