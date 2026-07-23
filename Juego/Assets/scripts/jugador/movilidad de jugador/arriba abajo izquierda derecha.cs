using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arribaabajoizquierdaderecha : MonoBehaviour
{
   public float velocidad = 10f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) rb.useGravity = false;
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 movimiento = new Vector3(x, y, 0f).normalized * velocidad * Time.deltaTime;

        transform.Translate(movimiento, Space.World);
    }
}
