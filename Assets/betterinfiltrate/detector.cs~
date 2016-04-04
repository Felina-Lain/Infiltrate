using UnityEngine;
using System.Collections;

public class detector : MonoBehaviour {

    public int speed;
    public Transform player;
	public NavMeshAgent agent;
	public float chronosave;
	public int state;
	public float chrono;


	void Update(){
		switch (state) {
			
		case 1:
			chrono -= Time.deltaTime;
			agent = transform.parent.gameObject.GetComponent<NavMeshAgent>();
			agent.SetDestination(player.position);
			transform.parent.gameObject.GetComponent<rondecleangoto>().enabled = false;
			if (chrono <= 0) {
				state = 0;}
			break;
			
		case 0:
			transform.parent.gameObject.GetComponent<rondecleangoto>().enabled = true;
			break;
		}
	}

    void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			chrono = chronosave;
			state = 1;
            
        }
	}
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
			state = 1;
        }
    }
	
}
