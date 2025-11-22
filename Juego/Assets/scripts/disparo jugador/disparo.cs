using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo_jugador : MonoBehaviour
{
       public Transform Disparo;
    public GameObject bala;
    public float fuerzaDisparo = 20f;
    public Camera camara;
    public float cooldown = 0.5f;

    private float siguiente_disparo = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= siguiente_disparo)
        {
            Direccion_Disparo();
            siguiente_disparo = Time.time + cooldown;
        }
    }

    void Direccion_Disparo()
    {
        Vector3 mouse = Input.mousePosition;

        mouse.z = Vector3.Distance(camara.transform.position, Disparo.position);

        Vector3 objetivo = camara.ScreenToWorldPoint(mouse);
        objetivo.z = Disparo.position.z;

        Vector3 direccion = (objetivo - Disparo.position).normalized;

        GameObject nuevaBala = Instantiate(bala, Disparo.position, Quaternion.LookRotation(direccion));
        nuevaBala.GetComponent<Rigidbody>().AddForce(direccion * fuerzaDisparo, ForceMode.Impulse);
    }
}
