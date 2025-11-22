using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minions_seguimiento_daño : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public int vida = 50;

    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.freezeRotation = true;
            rb.useGravity = false; 
        }
    }

    void FixedUpdate()
    {
        if (player != null && rb != null)
        {
     
            Vector3 direccion = (player.position - transform.position).normalized;

          
            rb.MovePosition(transform.position + direccion * speed * Time.fixedDeltaTime);

         
            if (direccion != Vector3.zero)
            {
                rb.MoveRotation(Quaternion.LookRotation(direccion));
            }
        }
    }

    public void TomarDamage(int damage)
    {
        vida -= damage;
        Debug.Log("Vida enemigo: " + vida);

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BALA"))
        {
            BALA_stats bala = other.GetComponent<BALA_stats>();
            if (bala != null)
            {
                TomarDamage(bala.dano);
            }

            Destroy(other.gameObject);
        }
    }
}
