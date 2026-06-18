using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private Cannon[] _cannonsToDisable;
    [SerializeField] private GameObject _winText;
    [SerializeField] private GameObject _finishPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Cannon cannon in _cannonsToDisable)
            {
                if (cannon != null)
                {
                    cannon.enabled = false;
                }
            }

            // Tutorial → cargar MainScene
            if (SceneManager.GetActiveScene().name == "Level1_Tutorial")
            {
                if (_winText != null)
                {
                    _winText.SetActive(true);
                }

                SceneManager.LoadScene("MainScene");
            }

            // MainScene → terminar el juego
            else if (SceneManager.GetActiveScene().name == "MainScene")
            {
                if (_finishPanel != null)
                {
                    _finishPanel.SetActive(true);
                }
            }
        }
    }
}