using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public PlayerHealth player;
    public TMP_Text healthText;
    public TMP_Text scoreText;

    void Update()
    {
        if (player != null)
            healthText.text = "Health: " + player.health;

        scoreText.text = "Score: " + GameManager.instance.score;
    }
}
