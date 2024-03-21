using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneOne : MonoBehaviour
{
    public string cutscene1;
    public void Cutscene1()
    {
        SceneManager.LoadScene(cutscene1);
    }
}
