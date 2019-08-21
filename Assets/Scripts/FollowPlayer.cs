using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform target;
	public float speed = 1.5f;
	public bool phathienvacham;
	public bool laplayer;
	public bool death = false;
	public bool FollowOrNot;
	private Animator anim;
	private GameObject player;
	private string sceneName;

	void Start () {
		anim = gameObject.GetComponent<Animator>();
		player = GameObject.FindWithTag("Player");
		sceneName = SceneManager.GetActiveScene ().name;

	}

	void Update(){
		
		if (sceneName == "MainGame") {
			Go ();
		} else {
			phathienvacham = true;
			laplayer = true;
			Go ();
		}
	}

	void Go(){
		
		if (player != null) {
			target = player.transform;
		}

		if (phathienvacham == true && laplayer == true && target != null && death == false) {
			anim.applyRootMotion = true;
			anim.SetBool ("Shoot", phathienvacham);
			transform.LookAt (target.position);
			transform.Rotate (new Vector3 (target.position.x, -90, target.position.z), Space.Self);

			if (FollowOrNot == true) {
				//move towards the player
				if (Vector3.Distance (transform.position, target.position) >= 2.5f) {
					transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
					anim.SetBool ("Shoot", false);
				}
			} else {
				if (Vector3.Distance (transform.position, target.position) >= 2.5f) {
					anim.applyRootMotion = false;
					anim.SetBool ("Shoot", false);
				} 
			}

		} else {
			//anim.applyRootMotion = false;
		}
	}
}
