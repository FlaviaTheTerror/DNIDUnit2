using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialOne : MonoBehaviour
{
    public string tutorialTwo;
    public void TutorialTwo()
    {
        SceneManager.LoadScene(tutorialTwo);
    }
}