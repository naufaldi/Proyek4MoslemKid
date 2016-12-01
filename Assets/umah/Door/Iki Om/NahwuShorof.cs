using UnityEngine;
using System.Collections;



public class NahwuShorof : MonoBehaviour {
	public Canvas test;
	public float deathDistance = 0;
	public Transform thisObject;
	public Transform target;
	public bool a = true;
	public AudioSource nahwu;
	public MouseLook[] look;
	//public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2, MouseZ = 3 }
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
		look = FindObjectsOfType<MouseLook> ();

	}

	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(target.position, transform.position);
		//look.jalan = false;
		if (dist <= deathDistance){
			//NGASIH PERTANYAA
			if(a==true){
				foreach (MouseLook o in look) {
					o.enabled = false;
				}
				Canvas.Instantiate(test);
				Time.timeScale = 0;
				a = false;
			}

		}
	}
}
