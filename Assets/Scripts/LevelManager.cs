using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int targetScore;
    public string nextScene;

    void Update()
    {
        if (GameManager.instance.score >= targetScore)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
