using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;
    public TextMeshProUGUI highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore").ToString("High score: " + "0");
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString("Score: "  + "0");

            if (score > PlayerPrefs.GetFloat("HighScore")) { }
            PlayerPrefs.SetFloat("HighScore", score);
        }
    }
}
