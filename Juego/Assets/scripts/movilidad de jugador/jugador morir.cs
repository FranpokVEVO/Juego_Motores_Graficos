using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jugadormorir : MonoBehaviour
{
    public AudioSource morir;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Ataque"))
        {
            Morir();
        }
    }

    private void Morir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                if (morir != null)
        {
            morir.Stop();
            morir.Play();
        }
    }
}
