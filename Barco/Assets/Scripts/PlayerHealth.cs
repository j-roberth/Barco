using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    public int Health
    {
        get { return _health; }
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
