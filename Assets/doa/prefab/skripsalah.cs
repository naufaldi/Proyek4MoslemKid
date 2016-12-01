using UnityEngine;
using System.Collections;

public class skripsalah : MonoBehaviour {
	private GameController gcgc;
	// Use this for initialization
	public void onClickSalah(){
		 GetComponent<AudioSource>().Play();
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		gcgc = gameController.GetComponent<GameController>();
		gcgc.MinHP (1);

	}
}
