using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidodisparo : MonoBehaviour
{
public AudioSource audioSource;
public AudioClip Disparo;

public void Dispara()
    {
        audioSource.PlayOneShot(Disparo);

    }
}
