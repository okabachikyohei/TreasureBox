using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {

	Transform player;

	NavMeshAgent nav;

	private Animator anim;
	private bool isTriggerEnter;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent>();
	}
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isTriggerEnter) {
			nav.SetDestination (player.position);
		}
//		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("run")) {
//				
//		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Player") {
			isTriggerEnter = true;
			anim.SetTrigger("PlayerEnter");
		}
	}
	
	void OnTriggerExit(Collider collider) {
		if (collider.gameObject.tag == "Player") {
			isTriggerEnter = false;
			anim.SetTrigger("PlayerExit");
		}
	}

	void Attack01Event() {	
		player.SendMessage ("BeAttacked");
	}

	void Attack02Event() {	
		player.SendMessage ("BeAttacked");
	}

}
