using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fondo : MonoBehaviour
{

 [SerializeField] private Vector2 velocidadMovimiento;

 private Vector2 offset;
private RawImage rawImage;
 private Material material;


    private void Awake()
    {
        rawImage = GetComponent<RawImage>();
material=rawImage.material;
    }
private void Update()
    {
        offset = velocidadMovimiento * Time.deltaTime;
        rawImage.uvRect = new Rect(offset, rawImage.uvRect.size);
        material.mainTextureOffset += offset;
    }

}
