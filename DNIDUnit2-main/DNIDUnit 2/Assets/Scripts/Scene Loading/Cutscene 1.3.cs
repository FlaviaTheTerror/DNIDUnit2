using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneThree : MonoBehaviour
{
    public string cutscene3;
    public void Cutscene3()
    {
        SceneManager.LoadScene(cutscene3);
    }
}
