using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALA_stats : MonoBehaviour
{
    public int dano = 10;

    private void Update()
    {
        transform.Translate(Vector3.forward * 30f * Time.deltaTime);
    }
}
