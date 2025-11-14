using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador_salto_invertido : MonoBehaviour

{
    public float gravedad = 9.81f;
    public float fuerzaSalto = 7f;
    public float fuerzaGravedadExtra = 20f;
    private Rigidbody rb;
    private bool enSuelo = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.down * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
        }
    }
    void FixedUpdate()
    {
        Vector3 direccion = Vector3.up;
        rb.AddForce(direccion * gravedad, ForceMode.Acceleration);
    }

    void OnCollisionStay(Collision col)
    {
        enSuelo = true;
    }

    void OnCollisionExit(Collision col)
    {
        enSuelo = false;
    }
}
