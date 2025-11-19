using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_De_Gravedad : MonoBehaviour
{
public float gravedad = 9.81f;
    private Rigidbody rb;
    private bool gravedadInvertida = false;
    private bool enSuelo = false;
    private AudioSource sonido;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        sonido = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            gravedadInvertida = !gravedadInvertida;
            transform.Rotate(180f, 0f, 0f);
            sonido.Play();
            particulas.Play();
        }
    }

    void FixedUpdate()
    {
        Vector3 direccion = gravedadInvertida ? Vector3.up : Vector3.down;
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
    [SerializeField] private ParticleSystem particulas;

}
