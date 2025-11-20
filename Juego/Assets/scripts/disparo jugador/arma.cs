using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class arma : MonoBehaviour
{
private Camera cam;

void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
      Vector3 mousePos = Input.mousePosition;
    mousePos.z = 10f;

    Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

    Vector3 direccion = mouseWorldPos - transform.position;

    transform.forward = direccion.normalized;
    }
}
