using UnityEngine;
using TMPro;

public class WinUI : MonoBehaviour
{
    TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();

        if (GameManager.instance != null)
            text.text = "Final Score: " + GameManager.instance.score;
    }
}
