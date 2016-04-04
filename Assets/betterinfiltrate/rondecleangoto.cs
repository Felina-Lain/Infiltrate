using UnityEngine;
using System.Collections;

public class rondecleangoto : MonoBehaviour {

    public Transform mark1;
    public Transform mark2;
    public int markcount;
    public int speed;
	private NavMeshAgent agent;
	public float chrono;

    // Use this for initialization
    void Start () {
		markcount = 1;
	}
	
	// Update is called once per frame
	void Update () {

       switch (markcount) {
			
		case 0:
			agent = GetComponent<NavMeshAgent>();
			agent.SetDestination(mark1.position);

			break;
			
		case 1:
			agent = GetComponent<NavMeshAgent>();
			agent.SetDestination(mark2.position);

			break;

		case 2:
			chrono -= Time.deltaTime;
			transform.Rotate(Vector3.up * Time.deltaTime * speed);
			if (chrono <= 0) {
				markcount = 0;}
			break;

		case 3:
			chrono -= Time.deltaTime;
			transform.Rotate(Vector3.up * Time.deltaTime * speed);
			if (chrono <= 0) {
				markcount = 1;}
			break;
		}
    }

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Mark1") {
			markcount = 3;
		}
		if (other.tag == "Mark2") {
			markcount = 2;
		}

	}
}
