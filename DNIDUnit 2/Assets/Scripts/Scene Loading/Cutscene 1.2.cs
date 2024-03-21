using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTwo : MonoBehaviour
{
    public string cutscene2;
    public void Cutscene2()
    {
        SceneManager.LoadScene(cutscene2);
    }
}
