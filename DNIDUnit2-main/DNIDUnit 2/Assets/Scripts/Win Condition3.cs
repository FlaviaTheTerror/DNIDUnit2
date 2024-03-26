using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition3 : MonoBehaviour
{
    void Update()
    {
        if(ScoreManager.scoreCount == 20)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
