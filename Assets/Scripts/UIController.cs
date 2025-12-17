using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public PlayerHealth player;
    public TMP_Text healthText;
    public TMP_Text scoreText;

    void Update()
    {
        if (player != null && healthText != null)
            healthText.text = "Health: " + player.health;

        if (scoreText != null && GameManager.instance != null)
            scoreText.text = "Score: " + GameManager.instance.score;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
