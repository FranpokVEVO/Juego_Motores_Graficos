using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio2 : MonoBehaviour
{
    public GameObject Enemigos;
    public GameObject Enemigos2; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorsalto salto = other.GetComponent<jugadorsalto>();
            arribaabajoizquierdaderecha movLibre = other.GetComponent<arribaabajoizquierdaderecha>();

            if (salto != null) salto.enabled = false;
            if (movLibre != null) movLibre.enabled = true;

            Transform arma = other.transform.Find("ARMA"); 
            if (arma != null) arma.gameObject.SetActive(true);
            if (Enemigos != null) Enemigos.SetActive(true);
            if (Enemigos2 != null) Enemigos2.SetActive(true);
        }
    }

}
