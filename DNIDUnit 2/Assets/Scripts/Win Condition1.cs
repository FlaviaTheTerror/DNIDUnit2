using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition1 : MonoBehaviour
{
    void Update()
    {
        if(ScoreManager.scoreCount == 10)
        {
            SceneManager.LoadScene("Cutscene 1.1");
        }
    }
}
