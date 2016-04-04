using UnityEngine;
using System.Collections;

public class detectorlong : MonoBehaviour {

	public Transform target;
	public float viewangle;
	public Vector3 MeHim;
	private NavMeshAgent agent;
	public float angle;
	public float chrono;
	public float chronosave;
	public int state;
	public Transform drawline1;
	public Transform drawline2;
	
	void OnDrawGizmos () {
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(transform.position, drawline1.position);
		Gizmos.DrawLine(transform.position, drawline2.position);
	}
	
	
	void Update () {

		Vector3 fwd = this.transform.forward;
		// Create a vector from the enemy to the player and store the angle between it and forward.
		MeHim = target.position - this.transform.position;
		angle = Vector3.Angle( MeHim, fwd);
		Debug.DrawLine (transform.position, target.position, Color.red);
		Debug.DrawLine (transform.position, fwd, Color.green);
		
		// If the angle between forward and where the player is, is less than the angle of view...
		if(angle < viewangle)
		{print ("angle is good");
			RaycastHit hit;
			
			// ... and if a raycast towards the player hits something...
			int layerMask = 1 << 9;
			layerMask = ~layerMask;
			if(Physics.Raycast(transform.position, MeHim.normalized, out hit, Mathf.Infinity, layerMask))
			{	Debug.DrawLine (transform.position, target.position, Color.cyan);
				print ("I hit sumthing");
				// ... and if the raycast hits the player...
				if(hit.collider.gameObject.tag == "Player")
				{	print ("assault!");
					state = 1;
					chrono = chronosave;
				}

			}
		}
		switch (state) {

		case 1:
			chrono -= Time.deltaTime;
			agent = transform.gameObject.GetComponent<NavMeshAgent>();
			agent.SetDestination(target.position);
			transform.gameObject.GetComponent<rondecleangoto>().enabled = false;
			if (chrono <= 0) {
				state = 0;}
			break;
			
		case 0:
			transform.gameObject.GetComponent<rondecleangoto>().enabled = true;
			break;
		}
	}
}