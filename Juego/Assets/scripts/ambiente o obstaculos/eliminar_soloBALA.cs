using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminar_soloBALA : MonoBehaviour
{
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("BALA"))
    {
        Destroy(other.gameObject);
    }
}
}
