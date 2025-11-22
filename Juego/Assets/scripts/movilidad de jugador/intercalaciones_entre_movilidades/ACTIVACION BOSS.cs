using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTIVACIONBOSS : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            GameObject mainCam = GameObject.FindWithTag("MainCamera");
            if (mainCam != null)
            {
              
                Transform bossTransform = mainCam.transform.Find("BOSS");
                if (bossTransform != null)
                {
                    bossTransform.gameObject.SetActive(true);
              
                }
                Transform enemigosTransform = mainCam.transform.Find("Enemigos");
                if (enemigosTransform != null)
                enemigosTransform.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
