using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Score: " + GameManager.instance.score;
    }
}
