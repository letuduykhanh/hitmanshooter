using UnityEngine;
using System.Collections;


public class SelfDestruct : MonoBehaviour
{
	public float timer = 0.5f;

	public GameObject explos;
	public GameObject leafs;
	public GameObject bricks;
	public GameObject box;
	int prefabLayer;

	void Start ()
	{
		prefabLayer = gameObject.layer;
	}

	void Update ()
	{
		timer -= Time.deltaTime;

		if (timer <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "KillHitman" || col.gameObject.tag == "Other" || col.gameObject.tag == "Wall" ||
		    col.gameObject.tag == "Human" || col.gameObject.tag == "Zombie" || col.gameObject.tag == "Robot" ||
		    col.gameObject.tag == "Alien" || col.gameObject.tag == "NPC" || col.gameObject.tag == "Car" ||
		    col.gameObject.tag == "BrownmanNPC" || col.gameObject.tag == "SurvivorNPC" || col.gameObject.tag == "Ball") {
			explosion ();
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Tree") {
			explosion ();
			GameObject leafsGo = (GameObject)Instantiate (leafs, transform.position, transform.rotation);
			leafs.layer = prefabLayer;
			Destroy (gameObject);
			Destroy (leafsGo, 2f);
		} else if (col.gameObject.tag == "FlowerPot" && gameObject.tag == "HitmanNormalbullet" ||
		           col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser01" || col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser02" ||
		           col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser03" || col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser04" ||
		           col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser05" || col.gameObject.tag == "FlowerPot" && gameObject.tag == "Laser06") {
			flowerpots (col);
		} else if (col.gameObject.tag == "Box" && gameObject.tag == "HitmanNormalbullet" ||
		           col.gameObject.tag == "Box" && gameObject.tag == "Laser01" || col.gameObject.tag == "Box" && gameObject.tag == "Laser02" ||
		           col.gameObject.tag == "Box" && gameObject.tag == "Laser03" || col.gameObject.tag == "Box" && gameObject.tag == "Laser04" ||
		           col.gameObject.tag == "Box" && gameObject.tag == "Laser05" || col.gameObject.tag == "Box" && gameObject.tag == "Laser06") {
			boxs (col);
		} else if (col.gameObject.tag == "FlowerPot" && gameObject.tag == "Humanbullet" ||
		           col.gameObject.tag == "FlowerPot" && gameObject.tag == "AlienBullet") {
			explosion ();
			Destroy (gameObject);
		} else if (col.gameObject.tag == "Box" && gameObject.tag == "Humanbullet" ||
		           col.gameObject.tag == "Box" && gameObject.tag == "AlienBullet") {
			explosion ();
			Destroy (gameObject);
		}
	}

	void explosion ()
	{
		Instantiate (explos, transform.position, transform.rotation);
	}

	void flowerpots (Collider2D collider)
	{
		explosion ();
		Instantiate (bricks, collider.gameObject.transform.position, collider.gameObject.transform.rotation);
		Instantiate (leafs, collider.gameObject.transform.position, collider.gameObject.transform.rotation);
		Destroy (collider.gameObject);
		Destroy (gameObject);
	}

	void boxs (Collider2D collider)
	{
		explosion ();
		Instantiate (box, collider.gameObject.transform.position, collider.gameObject.transform.rotation);
		Destroy (collider.gameObject);
		Destroy (gameObject);
	}
}
