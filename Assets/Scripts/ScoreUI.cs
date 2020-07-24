using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        SetScore(0);
    }

    public void SetScore(float score)
    {
        scoreText.text = "Score: " + ((int)score).ToString();
    }
}
