using UnityEngine;
using UnityEngine.InputSystem;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _cannonBallPrefab;
    [SerializeField] private Transform _cannonTip;
    [SerializeField] private GameObject _playerGO;
    [SerializeField] private float _shootTime;
    private float _shootTimer;

    void Start()
    {   
        _shootTimer = _shootTime;
    }   
    
    private void Update()
    {   
        _shootTimer -= Time.deltaTime;
        if (_shootTimer <=0)          
        {
            _shootTimer = _shootTime;
          Shoot();
        }
    }
    
    private void Shoot ()
    {
        var directionToPlayer = _playerGO.transform.position - _cannonTip.position;

            var cannonBall = Instantiate(_cannonBallPrefab, _cannonTip.position, Quaternion.identity);
            cannonBall.GetComponent<CannonBall>().SetDirection(directionToPlayer);
    }
}
