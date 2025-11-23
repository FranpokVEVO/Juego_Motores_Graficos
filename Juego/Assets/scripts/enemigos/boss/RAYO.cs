using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RAYO : MonoBehaviour
{
    public int vidaMax = 300;
    private int vidaActual;

    public GameObject objetoASpawnear;
    public float intervaloSpawn = 2f;
    public float yMin = -3f;
    public float yMax = 3f;

    private bool activo = true;

    void Start()
    {
        GetComponent<Collider>().enabled = true;
        Debug.Log("RAYO ACTIVADO, VIDA INICIAL = " + vidaActual);
    vidaActual = vidaMax;
    StartCoroutine(SpawnRoutine());
    }

    public void TomarDaño(int daño)
    {
        vidaActual -= daño;
        Debug.Log("Vida RAYO: " + vidaActual);

        if (vidaActual <= 0 && activo)
        {
            activo = false;
            Morir();
        }
    }
    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("BALA"))
    {
        TomarDaño(other.GetComponent<BALA_stats>().dano);
        Debug.Log("boss recibio bala");
        Destroy(other.gameObject); 
    }
}
    
    

    IEnumerator SpawnRoutine()
    {
        while (activo)
        {
            float yRandom = Random.Range(yMin, yMax);

            Vector3 spawnPos = new Vector3(transform.position.x, yRandom, transform.position.z);

            Instantiate(objetoASpawnear, spawnPos, Quaternion.Euler(0, 0, 90)); 

            yield return new WaitForSeconds(intervaloSpawn);
        }
    }

    void Morir()
    {
        GetComponent<Collider>().enabled = false;
        Destroy(gameObject);
        SceneManager.LoadScene("Menu");
    }
}
