using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorsalto : MonoBehaviour
{
public float fuerzaSalto = 8f;
    public float fuerzaGravedadExtra = 10f;
    bool enSuelo = true;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
[SerializeField] private ParticleSystem particulas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
            particulas.Play();
            
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
