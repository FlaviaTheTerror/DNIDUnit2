using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;

    // Use this for initialization
    void Start()
    {
        // Initialize scoreCount to 0 at the start of the game
        scoreCount = 0;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the score text
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // Update the text component with the current score
        scoreText.text = "Score: " + scoreCount;
    }

    // This method is used to add points to the score.
    public static void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}