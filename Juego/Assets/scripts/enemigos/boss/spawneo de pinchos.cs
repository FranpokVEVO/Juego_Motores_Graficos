using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneodepinchos : MonoBehaviour
{
 [SerializeField] private GameObject objetoPrefab; 
    [SerializeField] private float minInterval = 1f;  
    [SerializeField] private float maxInterval = 3f;  
    [SerializeField] private float xPosition = 0f;     
    [SerializeField] private float minY = 0f;         
    [SerializeField] private float maxY = 8f;         

    private void Start()
    {
        StartCoroutine(Spawnear());
    }

    private IEnumerator Spawnear()
    {
        while (true)
        {
            float y = Random.Range(minY, maxY);
            Vector3 posicion = new Vector3(xPosition, y, 0f);

            if (objetoPrefab != null)
                Instantiate(objetoPrefab, posicion, objetoPrefab.transform.rotation); 

            float intervalo = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(intervalo);
        }
    }
}
