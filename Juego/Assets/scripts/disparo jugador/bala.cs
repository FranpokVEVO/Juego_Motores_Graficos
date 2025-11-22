using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float speed;
    private float destruir = 1f;
    private Rigidbody balaRb;

    void Start()
    {
        balaRb = GetComponent<Rigidbody>();
    }
    public void disparo(Vector3 direccion)
    {
        balaRb.velocity = direccion * speed;
        Destroy(gameObject, destruir);
    }
    private void OnCollisionEnter(Collision colision)
    {
        Destroy(gameObject);
    }
}