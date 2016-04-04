using UnityEngine;
using System.Collections;

public class killplayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider coll_) {

		print ("caught ya!" + coll_.name);

		if (coll_.gameObject.name == "Player"){

			Destroy (coll_.gameObject);
		}
	}
}
