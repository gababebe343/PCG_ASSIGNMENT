using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    PlayerHealth player;
    TMP_Text healthText;
    TMP_Text scoreText;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Start()
    {
        BindReferences();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        BindReferences();
    }

    void BindReferences()
    {
        player = FindFirstObjectByType<PlayerHealth>();

        GameObject h = GameObject.Find("HealthText");
        if (h != null)
            healthText = h.GetComponent<TMP_Text>();

        GameObject s = GameObject.Find("ScoreText");
        if (s != null)
            scoreText = s.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (player != null && healthText != null)
            healthText.text = "Health: " + GameManager.instance.playerHealth;

        if (scoreText != null && GameManager.instance != null)
            scoreText.text = "Score: " + GameManager.instance.score;
    }

    public void RestartLevel()
    {
        if (GameManager.instance != null)
            GameManager.instance.ResetGame();

        SceneManager.LoadScene("Level1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadLevel1()
    {
        if (GameManager.instance != null)
            GameManager.instance.ResetGame();

        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
