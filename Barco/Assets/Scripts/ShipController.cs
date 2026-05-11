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
        Vector3 move = transform.forward * _input.y * velocidad;
        _rb.linearVelocity = move;

        float rot = _input.x * velocidadGiro * Time.fixedDeltaTime;
        _rb.MoveRotation(_rb.rotation * Quaternion.Euler(0, rot, 0));
    }

    public void OnMove(InputValue value)
    {
        _input = value.Get<Vector2>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Colision contra{collision.gameObject.name}");   
    }
}