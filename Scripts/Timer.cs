using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeRemaining = 30;
    private Text timerText;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "" + timeRemaining;
        }
        else if (timeRemaining < 0)
        {
            GameOver.isPlayerDead = true;
            timeRemaining = 0;
        }
       
    }

}
