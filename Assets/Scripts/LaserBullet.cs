using UnityEngine;
using System.Collections;

public class LaserBullet : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "KillHitman") {
			transform.parent.GetComponent<Animator> ().Play ("collectReward");
			Destroy (gameObject);
			Destroy (transform.parent.gameObject, 1);
		}
	}
}
