using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorsalto : MonoBehaviour
{
    public float fuerzaSalto = 8f;
    bool enSuelo = true;
    Rigidbody rb;
    public float fuerzaGravedadExtra = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
        }
        if (rb.velocity.y < 0)
{
    rb.AddForce(Vector3.down * fuerzaGravedadExtra, ForceMode.Acceleration);
}
    }

    void OnCollisionEnter(Collision col)
    {
        enSuelo = true;
    }
}
