using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIODEFASE : MonoBehaviour
{
[SerializeField] private GameObject boss;
[SerializeField] private GameObject enemigos;
    public void Cambiar()
    {
        if (boss != null)
        {
            boss bossScript = boss.GetComponent<boss>();
            if (bossScript != null)
                bossScript.enabled = false;

            RAYO rayoScript = boss.GetComponent<RAYO>();
            if (rayoScript != null)
                rayoScript.enabled = true;
        }
                if (enemigos != null)
        {
            enemigos.SetActive(false);
        }
    }
}
