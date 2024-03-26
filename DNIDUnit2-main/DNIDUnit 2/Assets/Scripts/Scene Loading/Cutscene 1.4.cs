using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneFour : MonoBehaviour
{
    public string cutscene4;
    public void Cutscene4()
    {
        SceneManager.LoadScene(cutscene4);
    }
}
