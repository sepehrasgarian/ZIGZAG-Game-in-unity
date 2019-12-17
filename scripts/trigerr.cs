using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerr : MonoBehaviour {
	int i=0;
	public GameObject partickele;

	
	void OnTriggerEnter(Collider col){
		//Debug.Log ("innnnnnnnnnnnnnnnnnn");
		if (col.gameObject.tag.Equals ("Ball")) {
			GetComponent<MeshRenderer> ().enabled = false;
			GameObject part=Instantiate (partickele, col.gameObject.transform.position, Quaternion.identity);
			Destroy (part, 1f);
		}
	}
	// Use this for initialization 
	void Start () {
		//Debug.Log ("started");
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (i);
	}
}
