using UnityEngine;
using System.Collections;

public class scriptButtonWrong : MonoBehaviour {
	public void onClick(Canvas soal){
		GetComponent<AudioSource>().Play();
		soal.gameObject.SetActive(false);
		Time.timeScale = 1;

	}

	public void onClick2(GameObject Musuh){

	}
}
