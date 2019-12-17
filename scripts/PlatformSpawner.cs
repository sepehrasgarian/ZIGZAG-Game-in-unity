using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {
	Vector3 lastpos;
	public GameObject platform;
	public GameObject diamond;
	float size ;//size of our platform
	public bool gameover;

	 
	// Use this for initialization
	void Start ()
	{   //Debug.Log ("varedesh shude ");
		spawnz();
		gameover = false;
		lastpos = platform.transform.position;
		size = platform.transform.localScale.x;
//		for (int i = 0; i < 5; i++) {
//			spawnplatform ();
//		}

		InvokeRepeating ("spawnplatform", 0.6f, 0.2f);


	}

	
	// Update is called once per frame
	void Update () {
		if (gameover) {
			CancelInvoke ("spawnplatform");}
		 
	}
	 
	void spawnplatform(){
	
		int x = Random.Range (0, 6);
		if (x < 3)
			spawnx ();
		else
			spawnz ();
	
	
	
	}




	void spawnx(){
		//Debug.Log ("inter");
		Vector3 pos = lastpos;
		pos.x += size;
		Instantiate (platform, pos, Quaternion.identity);
		lastpos = pos;
		int x = Random.Range (0, 6);
		if (x < 1)
			Instantiate (diamond,new Vector3(pos.x,pos.y+1,pos.z), diamond.transform.rotation);

	}
	void spawnz(){
		Vector3 pos = lastpos;
		pos.z += size;
		Instantiate (platform, pos, Quaternion.identity);
		lastpos = pos;
		int x = Random.Range (0, 6);
		if (x < 1)
			Instantiate (diamond,new Vector3(pos.x,pos.y+1,pos.z), diamond.transform.rotation);
	}
 

}
