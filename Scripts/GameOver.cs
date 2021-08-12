﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public static bool isPlayerDead = false;
	private Text gameOver;

	void Start () {
		gameOver = GetComponent<Text> ();
		gameOver.enabled = false;
	}

	void Update () {
		if (isPlayerDead) {
			if (Scoring.HighScore < Scoring.playerScore)
			{
				Scoring.HighScore = Scoring.playerScore;
			}
			Time.timeScale = 0;
			gameOver.enabled = true;
		}
	}
}
