using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTorreta : MonoBehaviour
{
    [SerializeField] float magnitudA = 90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direccionH = new Vector3(0, 1, 0);
        float sentidoH = Input.GetAxis("HorizontalTorreta");

        Vector3 velocidadH = magnitudA * direccionH * sentidoH;
        Vector3 distanciaH = velocidadH * Time.deltaTime;
        transform.eulerAngles = transform.eulerAngles + distanciaH;
    }
}
