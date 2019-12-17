using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour {
	public GameObject ball;
	Vector3 offset;
	public float lerprate;
	public bool gameoverr;

	// Use this for initialization
	void Start () {
		offset = ball.transform.position - transform.position;
		gameoverr = false;

	}

	// Update is called once per frame
	void Update () {
		if (!gameoverr) {
			Faloow();}

	}
	void Faloow () {
		Vector3 pos = transform.position;
		Vector3 targetpostion = ball.transform.position - offset;
		pos=Vector3.Lerp (pos, targetpostion, lerprate * Time.deltaTime);
		transform.position = pos;

	}
}

