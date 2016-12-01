using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Chase : MonoBehaviour {
	public float deathDistance = 0.5f;
	public float distanceAway;
	public Transform thisObject;
	public Transform target;
	private NavMeshAgent navComponent;

	public Canvas test;
	public Text soal;
	public GameObject Kanpas;
	public bool a = true;
	
	void Start(){
		target = GameObject.FindGameObjectWithTag("Player").transform;
		navComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	void Update(){		
		var distanceAway = 40f;

		float dist = Vector3.Distance(target.position, transform.position);	
		if (dist < distanceAway) {
			navComponent.SetDestination (target.position);
		} else {
			this.thisObject = null;
		}
		if (dist <= deathDistance) {
			//NGASIH PERTANYAAN
			if (a == true) {
				Canvas.Instantiate (test);
				a = false;
				Time.timeScale = 0;
			}
		}
		}
	
	}
	
