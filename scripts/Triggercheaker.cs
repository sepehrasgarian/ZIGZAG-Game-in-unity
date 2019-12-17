using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerCheaker : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnExitTrigger(Collider cal){
		if (cal.gameObject.tag == "Ball")
			Invoke ("falldown", 0.7f);
	}
	void falldown(){
		GetComponentInParent<Rigidbody> ().useGravity = true;

	}
}
