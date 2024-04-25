using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text ScoreNumText;

    public GameObject resultPanel;
    public Text resultText;
    private void Awake()
    {
        Instance = this;
    }


    public void UpdateScoreNumText(int num)
    {
        ScoreNumText.text = num.ToString();
    }

    public void GameResult(bool isWin)
    {
        resultPanel.SetActive(true);
        if (isWin)
        {
            resultText.text = "ƒ„”Æ¡À";
        }
        else
        {
            resultText.text = "ƒ„ ‰¡À";
        }
    }
}
