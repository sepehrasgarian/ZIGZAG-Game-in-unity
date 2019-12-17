using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private float speed;
	bool started;
	bool gameOver;
	Rigidbody rb;
	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}
	void Start () {
		started = false;
		gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			if (Input.GetMouseButtonDown (0) && !gameOver) {
				rb.velocity = new Vector3 (speed, 0, 0);
				started = true;
			}
		}
		Debug.DrawRay (transform.position, Vector3.down, Color.red);
		if (Input.GetMouseButtonDown (0))
			Swichdirection ();
		if (!Physics.Raycast (transform.position, Vector3.down, 1f)) {
			gameOver = true;
			rb.velocity = new Vector3 (0, -25f, 0);
			Camera.main.GetComponent<CameraFallow> ().gameoverr = true;
		}
		
	}
	void Swichdirection(){
		if (rb.velocity.z > 0) {
			rb.velocity = new Vector3 (speed, 0, 0);}
		else if (rb.velocity.x > 0) {
			rb.velocity = new Vector3 (0, 0, speed);}
	}
}
