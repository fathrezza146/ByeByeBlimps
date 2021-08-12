using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        myButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Scoring.HighScore >= 1000)
        {
            myButton.interactable = true;
        }
    }

    void TaskOnClick(Collider Control)
    {
        Control frate = Control.GetComponent<Control>();
        frate.fireRate = 0.1f;
        myButton.interactable = false;
    }
}
