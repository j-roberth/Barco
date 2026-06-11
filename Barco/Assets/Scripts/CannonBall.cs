using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _ballDirection;

    public void SetDirection(Vector3 direction)
    { 
        _ballDirection = direction;
    }

    private void Update()
    {
        //Vector3 ballMovement = new Vector3(_ballDirection.x * _speed * Time.deltaTime, _ballDirection.y * _speed * Time.deltaTime, _ballDirection.z * _speed * Time.deltaTime);

        Vector3 ballMovement = _ballDirection * _speed * Time.deltaTime;

        transform.position += ballMovement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Colisionócontra {collision.gameObject.name}"); 
        PlayerHealth playerHealth =
            collision.gameObject.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(10);
        }

        Destroy(gameObject);
    }
}