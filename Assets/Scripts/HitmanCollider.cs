using UnityEngine;
using System.Collections;

public class HitmanCollider : MonoBehaviour {
	private FollowPlayer followplayer;

	// Use this for initialization
	void Start () {
		followplayer = gameObject.GetComponentInParent<FollowPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(followplayer!=null){
			followplayer.phathienvacham = true;
		}

		if (col.gameObject.tag == "HitmanSpy" || col.gameObject.tag == "Player" ) {
			followplayer.laplayer = true;
		}
	}
}
