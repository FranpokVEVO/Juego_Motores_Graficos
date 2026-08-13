using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoboss : MonoBehaviour
{
public AudioSource audioSource;
public AudioClip dispara;

public void playDisparoBOSS()
    {
        audioSource.PlayOneShot(dispara);

    }
}
