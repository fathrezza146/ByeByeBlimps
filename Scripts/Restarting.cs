using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarting : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scoring.playerScore = 0;
            GameOver.isPlayerDead = false;
            SceneManager.LoadScene("Scenery");
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
           
            GameOver.isPlayerDead = false;
            SceneManager.LoadScene("Menu");
            Scoring.playerScore = 0;
            Time.timeScale = 1;
        }
    }
}
