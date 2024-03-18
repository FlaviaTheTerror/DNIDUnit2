using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startTutorial;
    public void StartTutorial()
    {
        SceneManager.LoadScene(startTutorial);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
