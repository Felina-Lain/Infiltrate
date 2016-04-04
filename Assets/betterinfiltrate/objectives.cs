using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class objectives : MonoBehaviour {

	public static bool haskey;
	public Text uI;

	// Use this for initialization
	void Start () {

		haskey = false;
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider coll) {

		print ("coll name" + coll.name);
		print ("this" + this.name);
	
		if (this.transform.name == "key" && coll.transform.tag == "Player") {
		
			haskey = true;
		
		}

		if (this.transform.name == "vent" && coll.transform.tag == "Player" && haskey) {
			uI.text = "YOU Win!";
			
		}
	}
}
