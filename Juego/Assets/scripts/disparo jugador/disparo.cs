using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo_jugador : MonoBehaviour
{
    public Transform Disparo;
    public bool disparo;
    public GameObject bala;
    void Update()


    {
        disparo = Input.GetKeyDown(KeyCode.Mouse0);
        if (disparo)
        {
            instantiatebala();
        }

    }
    public void instantiatebala()
    {
        Instantiate(bala, Disparo.position, Disparo.rotation);
    }

}
