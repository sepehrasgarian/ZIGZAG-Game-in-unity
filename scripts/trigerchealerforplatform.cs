using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerchealerforplatform : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		//Debug.Log ("omdero");
		if (col.gameObject.tag.Equals ("Ball")) {
          Invoke ("falldown", 0.7f);
		}
	}
	void falldown(){
		Debug.Log("chashm");
		GetComponentInParent<Rigidbody>().useGravity = true;
		Destroy (transform.parent.gameObject, 2f);

		}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
