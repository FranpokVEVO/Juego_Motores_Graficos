using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimnar : MonoBehaviour
{
void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("BALA") && other.CompareTag("Player"))
        {
               Destroy(other.gameObject); 
        }
    
        
    }
}
