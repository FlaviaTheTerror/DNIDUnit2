using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    void Update()
    {
        if(ScoreManager.scoreCount == 25)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
