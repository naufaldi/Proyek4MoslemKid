using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public Text HPText;
	public Canvas GameOver;
	public Text Skore;
	public Text gameOver;
	double skor;
	private int healthPoint;
	public MouseLook[] look;
	// Use this for initialization
	void Start () {
		healthPoint = 3;
		UpdateScore_HP ();
		skor = 0;
		look = FindObjectsOfType<MouseLook> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MinHP(int newHealthPoint){
		healthPoint -= newHealthPoint;
		UpdateScore_HP ();
	}

	public void UpdateScore_HP(){
		foreach (MouseLook o in look) {
			o.enabled = true;
		}
		Skore.text = "Score: " + skor.ToString ();
		HPText.text= "HP: " + healthPoint.ToString ();
		gameOver.text = "Game Over Scoremu = " + skor.ToString ();
		if (healthPoint <= 0 || skor>=100) {
			Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
			Destroy(GameObject.FindGameObjectWithTag("hp"));
			Instantiate(GameOver);
			Time.timeScale = 1;
		}
	}

	public void addScore(double sekor){
		
		skor += sekor;
		UpdateScore_HP ();
	}
}