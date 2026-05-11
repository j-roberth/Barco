using UnityEngine;
using UnityEngine.InputSystem;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _cannonBallPrefab;
    [SerializeField] private Transform _cannonTip;
    [SerializeField] private GameObject _playerGO;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) //Cambiar la forma en la que se spawnean las balas. Hacer que sea automaticamente cuando el player está a cierto rango. Y que dispare con una cadencia (por ejemplo cada 5 segundos).
        {
            var directionToPlayer = _playerGO.transform.position - _cannonTip.position;

            var cannonBall = Instantiate(_cannonBallPrefab, _cannonTip.position, Quaternion.identity);
            cannonBall.GetComponent<CannonBall>().SetDirection(directionToPlayer);
        }
    }
}
