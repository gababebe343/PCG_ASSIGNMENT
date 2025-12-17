using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

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
        Debug.Log("Score is now: " + score);
    }
}
