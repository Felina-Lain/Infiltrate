﻿using UnityEngine;
using System.Collections;

public class lighton : MonoBehaviour {

	public Transform enemy1;
	public Transform enemy2;
	public Transform enemy3;
	public static bool lightsnoton;
	public Light biglight;
	public static float chrono;

	// Use this for initialization
	void Update () {
		if (lightsnoton) {
			chrono -= Time.deltaTime;
		}
		if(chrono <= 0){ lightsnoton = false;
			chrono = 10;
		}
		
		print ("lightchrono" + chrono);

	}
	
	// Update is called once per frame
	void OnTriggerStay () {
	
		if(Input.GetKey(KeyCode.Space)){
			lightsnoton = true;

		}

		if(lightsnoton){
			biglight.enabled = false;
			enemy1.transform.gameObject.GetComponent<detectorlong>().enabled = false;
			enemy1.transform.gameObject.GetComponentInChildren<detector>().enabled = true;
			enemy2.transform.gameObject.GetComponent<detectorlong>().enabled = false;
			enemy2.transform.gameObject.GetComponentInChildren<detector>().enabled = true;
			enemy3.transform.gameObject.GetComponent<detectorlong>().enabled = false;
			enemy3.transform.gameObject.GetComponentInChildren<detector>().enabled = true;
		}else{
			biglight.enabled = true;
			enemy1.transform.gameObject.GetComponent<detectorlong>().enabled = true;
			enemy1.transform.gameObject.GetComponentInChildren<detector>().enabled = false;
			enemy2.transform.gameObject.GetComponent<detectorlong>().enabled = true;
			enemy2.transform.gameObject.GetComponentInChildren<detector>().enabled = false;
			enemy3.transform.gameObject.GetComponent<detectorlong>().enabled = true;
			enemy3.transform.gameObject.GetComponentInChildren<detector>().enabled = false;
		}

	}
}
