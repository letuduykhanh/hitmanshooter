using UnityEngine;
using System.Collections;

public class SmokeCollider : MonoBehaviour {
	public float timer = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		//Destroy (gameObject);
	}
}
