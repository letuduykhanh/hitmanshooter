using UnityEngine;
using System.Collections;

public class KickBall : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Ball" && (gameObject.tag == "SurvivorNPC")) {
			animator.Play ("survivor_kick");

		} else if (col.gameObject.tag == "Ball" && (gameObject.tag == "BrownmanNPC")) {
			animator.Play ("brownman_kick");
		}
	}
}
