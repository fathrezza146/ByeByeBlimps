using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
	private Text firee;

	void Start()
	{
		firee = GetComponent<Text>();
		firee.enabled = false;
	}

	void Update()
	{
		if (Scoring.playerScore >= 1000 && Scoring.HighScore < 1000)
		{
			firee.enabled = true;
		}
	}
}
