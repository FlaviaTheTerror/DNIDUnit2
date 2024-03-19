using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoTitle : MonoBehaviour
{
    public string TitleScreen;
    public void EndGame()
    {
        SceneManager.LoadScene(TitleScreen);
    }
}
