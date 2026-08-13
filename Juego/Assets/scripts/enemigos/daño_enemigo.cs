using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class daño_enemigo : MonoBehaviour
{
    public int maxGolpes = 3; 
    private int golpesRecibidos = 0;

    public void Morir()
    {
        golpesRecibidos++;

        Debug.Log("Golpes recibidos: " + golpesRecibidos);

        if (golpesRecibidos >= maxGolpes)
        {
            Debug.Log("Jugador muerto");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}