#pragma strict

var theDoor :Transform;
private var drawGUI=false;
private var doorIsClosed = true;

function Update () {
	if(drawGUI==true&&Input.GetKeyDown(KeyCode.E)){
		changeDoorState();
	}

}

function OnTriggerEnter (theCollider : Collider) {
	if(theCollider.tag=="Player"){
		drawGUI=true;
	}
}

function OnTriggerExit (theCollider : Collider) {
	if(theCollider.tag=="Player"){
		drawGUI=false;
	}
}

function OnGUI(){
	if(drawGUI==true){
		GUI.Box(Rect(Screen.width*0.5-50, 200, 210, 22), "Jawablah untuk Masuk Dapur");
	}
}
function changeDoorState(){
	if(doorIsClosed==true){
		theDoor.GetComponent.<Animation>().CrossFade("Open");
		//theDoor.audio.PlayOneShot();
		doorIsClosed=false;
		yield WaitForSeconds(3);
		theDoor.GetComponent.<Animation>().CrossFade("Close");
		//theDoor.audio.Play();
		doorIsClosed=true;
	}
}