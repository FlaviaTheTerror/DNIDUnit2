using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialTwo : MonoBehaviour
{
    public string startGame;
    public void StartGame()
    {
        SceneManager.LoadScene(startGame);
    }
}
