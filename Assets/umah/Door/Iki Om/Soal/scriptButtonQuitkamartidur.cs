using UnityEngine;
using System.Collections;

public class scriptButtonQuitkamartidur : MonoBehaviour {
	private GameController gcgc;

	public void onClick(Canvas soal){
		soal.gameObject.SetActive(false);
		GetComponent<AudioSource>().Play();
		Time.timeScale = 1;
		GameObject soal1 = GameObject.FindGameObjectWithTag("kamartidur");
		soal1.gameObject.SetActive(false);
		
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		gcgc = gameController.GetComponent<GameController>() ;
		gcgc.addScore (12.5);
	}

}
