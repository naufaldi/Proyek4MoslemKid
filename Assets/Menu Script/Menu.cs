using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public Canvas Start;
	public Button Begin;
	public Button Exit;

	public void Mulai(){
		Application.LoadLevel (1);

	}
	public void Keluar(){
		Application.Quit ();
	}
	public void PlaySound()
	{
		GetComponent<AudioSource>().Play();
	}
	// Use this for initialization
	
}
