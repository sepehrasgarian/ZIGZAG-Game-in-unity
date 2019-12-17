using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerforspawn : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Debug.Log ("nane");
		if (col.gameObject.tag.Equals ("Ball")) {
			Invoke ("falldown", 0.7f);
		}
	}
	void falldown(){
		Debug.Log("spawn");
		GetComponentInParent<Rigidbody>().useGravity = true;
		Destroy (transform.parent.gameObject, 2f);

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
