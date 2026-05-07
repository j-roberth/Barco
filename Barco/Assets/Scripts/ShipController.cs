using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public float velocidad = 10f;
    public float velocidadGiro = 50f;

    private Vector2 _input;
    [SerializeField] private Rigidbody _rb;



    void FixedUpdate()
    {
        float inputvertical = _input.y;

        float inputHorizontal = _input.x;

        Vector3 vectorDeGiro = new Vector3(0, velocidadGiro * inputHorizontal, 0);
        Quaternion deltaRotation = Quaternion.Euler(vectorDeGiro * Time.fixedDeltaTime);

        Vector3 movimiento = transform.forward * inputvertical * velocidad * Time.fixedDeltaTime;

        Debug.Log(movimiento);

        _rb.MovePosition(_rb.position + movimiento);
        _rb.MoveRotation(_rb.rotation * deltaRotation);

        //Movimiento por transform (sin fisicas)
        //transform.Translate(Vector3.forward * movimientoVertical * velocidad * Time.deltaTime);
        //transform.Rotate(Vector3.up * movimientoHorizontal * velocidadGiro * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        _input = value.Get<Vector2>();
    }
}