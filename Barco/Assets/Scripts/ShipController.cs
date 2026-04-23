using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBarco : MonoBehaviour
{
    public float velocidad = 10f;
    public float velocidadGiro = 50f;

    void Update()
    {
      float movimientoVertical = Input.GetAxis("Vertical");
        
      float movimientoHorizontal = Input.GetAxis("Horizontal");

      transform.Translate(Vector3.forward * movimientoVertical * velocidad * Time.deltaTime);

      transform.Rotate(Vector3.up * movimientoHorizontal * velocidadGiro * Time.deltaTime);
    }
}