﻿using UnityEngine;
using System.Collections;

public class scriptButtonQuitruangbelajar : MonoBehaviour {
	private GameController gcgc;

	public void onClick(Canvas soal){
		GetComponent<AudioSource>().Play();
		soal.gameObject.SetActive(false);
		Time.timeScale = 1;
		GameObject soal1 = GameObject.FindGameObjectWithTag("ruangbelajar");
		soal1.gameObject.SetActive(false);
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		gcgc = gameController.GetComponent<GameController>();
		gcgc.addScore (12.5);
	}

}
