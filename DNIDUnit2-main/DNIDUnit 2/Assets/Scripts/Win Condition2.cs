using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition2 : MonoBehaviour
{
    void Update()
    {
        if(ScoreManager.scoreCount == 15)
        {
            SceneManager.LoadScene("Cutscene 2.1");
        }
    }
}
