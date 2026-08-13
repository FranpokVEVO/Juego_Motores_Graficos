using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIODEFASE : MonoBehaviour
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

                   
                    boss bossScript = bossTransform.GetComponent<boss>();
                    if (bossScript != null) bossScript.enabled = false;

                 
                    RAYO rayoScript = bossTransform.GetComponent<RAYO>();
                    if (rayoScript != null) rayoScript.enabled = true;
                }

            
                Transform enemigosTransform = mainCam.transform.Find("Enemigos");
                if (enemigosTransform != null)
                {
                    enemigosTransform.gameObject.SetActive(false);
                }
            }

            // Desactivar el trigger
            gameObject.SetActive(false);
        }
    }
}
