using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.scoreCount += 1;
        }
    }
}
