var warptarget : Transform;


function Update () {
	
}

function OnTriggerEnter (col : Collider){
	if(col.gameObject.tag == "Warp001"){
		this.transform.position = warptarget.position;
	}
}
