using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private Cannon[] _cannonsToDisable;
    [SerializeField] private GameObject _winText;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entró algo: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Llegaste al muelle!");

            foreach (Cannon cannon in _cannonsToDisable)
            {
                if (cannon != null)
                {
                    cannon.enabled = false;
                }
            }

            if (_winText != null)
            {
                _winText.SetActive(true);
            }

            SceneManager.LoadScene("MainScene");
        }
    }
}