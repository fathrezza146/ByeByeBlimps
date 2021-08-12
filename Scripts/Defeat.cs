using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{

    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.childCount == 0)
        {
            GameOver.isPlayerDead = true;
        }
    }
}
