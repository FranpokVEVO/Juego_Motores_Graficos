using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueBOSS : MonoBehaviour
{
public float speed = 10f;
    private Vector3 objetivo; 

    void Start()
    {
       
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        objetivo = player.position; 
    }

    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, objetivo, speed * Time.deltaTime);

       
        if (transform.position == objetivo)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            Destroy(gameObject);
        }
    }
}
