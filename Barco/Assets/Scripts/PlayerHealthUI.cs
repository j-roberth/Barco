using UnityEngine;
using TMPro;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Update()
    {
        _healthText.text = "Health: " + _playerHealth.Health;
    }
}