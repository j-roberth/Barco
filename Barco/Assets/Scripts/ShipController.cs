using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class ShipController : MonoBehaviour
{
    public float velocidad = 10f;
    public float velocidadGiro = 50f;

    private Vector2 _input;

    void Update()
    {
      float movimientoVertical = _input.y;
        
      float movimientoHorizontal = _input.x;

      transform.Translate(Vector3.forward * movimientoVertical * velocidad * Time.deltaTime);

      transform.Rotate(Vector3.up * movimientoHorizontal * velocidadGiro * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        _input = value.Get<Vector2>();
    }
}