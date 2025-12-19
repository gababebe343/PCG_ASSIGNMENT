using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public int playerHealth = 1;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public void DamagePlayer(int damage)
    {
        playerHealth -= damage;
    }

    public void ResetGame()
    {
        score = 0;
        playerHealth = 100;
    }
}
