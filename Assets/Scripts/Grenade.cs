using UnityEngine;
using System.Collections;
using System;

public class Grenade : MonoBehaviour
{

	public float maxSpeed = 5f;
	int count;
	public GameObject leafs;
	public GameObject bricks;
	public GameObject box;
	int prefabLayer;
	bool playsound = true;

	void Start ()
	{
		prefabLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update ()
	{
		count++;
		if (count <= 30 && maxSpeed == 5f) {
			Vector3 pos = transform.position;
			Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
			pos += transform.rotation * velocity;
			transform.position = pos;

		}
			
	}

	IEnumerator OnTriggerEnter2D (Collider2D col)
	{
		Destroy (gameObject, 3);

		if (playsound == true) {
			gameObject.GetComponent<AudioSource> ().Play ();
			playsound = false;
		}

		if (col.gameObject.tag == "KillHitman" || col.gameObject.tag == "Other" || col.gameObject.tag == "Wall" ||
		    col.gameObject.tag == "Human" || col.gameObject.tag == "NPC" || col.gameObject.tag == "Car" ||
		    col.gameObject.tag == "Zombie" || col.gameObject.tag == "Robot" || col.gameObject.tag == "Alien" ||
		    col.gameObject.tag == "BrownmanNPC" || col.gameObject.tag == "SurvivorNPC" || col.gameObject.tag == "Ball") {
			maxSpeed = 0;
			//Destroy (gameObject);
		} else if (col.gameObject.tag == "Tree") {
			maxSpeed = 0;
			GameObject leafsGo = (GameObject)Instantiate (leafs, transform.position, transform.rotation);
			leafs.layer = prefabLayer;
			Destroy (leafsGo, 0.5f);
		} else if (col.gameObject.tag == "FlowerPot" && gameObject.tag == "Bomb") {
			maxSpeed = 0;
			Destroy (col.gameObject, 1.9f);

			yield return new WaitForSeconds (1.8f);

			try {
				Instantiate (bricks, col.gameObject.transform.position, col.gameObject.transform.rotation);
				Instantiate (leafs, col.gameObject.transform.position, col.gameObject.transform.rotation);
			} catch (Exception e) {
				print (e);
			}

		} else if (col.gameObject.tag == "Box" && gameObject.tag == "Bomb") {
			maxSpeed = 0;
			Destroy (col.gameObject, 1.9f);
				
			yield return new WaitForSeconds (1.8f);

			try {
				Instantiate (box, col.gameObject.transform.position, col.gameObject.transform.rotation);
			} catch (Exception e) {
				print (e);
			}
		}
	}
}
