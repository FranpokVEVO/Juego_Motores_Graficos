using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jugadormorir : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Ataque"))
        {
            Debug.Log("Golpe recibido de: " + other.name);
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log("Jugador muerto");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
