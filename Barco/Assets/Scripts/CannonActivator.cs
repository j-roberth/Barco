using UnityEngine;

public class CannonActivator : MonoBehaviour
{
    [SerializeField] private Cannon _cannon;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _cannon.enabled = true;
        }
    }
}