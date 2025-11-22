using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minions_seguimiento_daño : MonoBehaviour
{
 
    public Transform player;
    public float speed = 3f;

  
    public int vida = 50;

    void Update()
    {
    
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
            transform.LookAt(player);
        }
    }
    public void TomarDamage(int damage)
    {
        vida -= damage;
        Debug.Log("Enemigo vida: " + vida);

        if (vida <= 0)
        {
            Morir();
        }
    }

    void Morir()
    {
        Destroy(gameObject);
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
