using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KillHitman : MonoBehaviour
{
	public GameObject deathparticle;
	public GameObject bloodeffect;
	public int hitmanhealth = 20;
	public int count;
	private PlayerMovement playermovement;
	private PlayerShooting playershooting;
	public AudioSource[] audio;
	//public int currenthealth;
	public bool death;
	string sceneName;
	// Use this for initialization
	void Start ()
	{
		sceneName = SceneManager.GetActiveScene ().name;
		playermovement = GetComponentInParent<PlayerMovement> ();
		playershooting = GetComponentInParent<PlayerShooting> ();
	}

	IEnumerator Wait (float waitTime)
	{
		transform.root.GetComponentInParent<Animator> ().enabled = true;
		transform.root.GetComponentInParent<Animator> ().Play ("hitman_chet");
		yield return new WaitForSeconds (waitTime);
		Destroy (transform.parent.gameObject);

	}

	// Update is called once per frame
	void Update ()
	{
		
		if (hitmanhealth <= 0) {
			death = true;
			playermovement.death = true;
			playershooting.death = true;
			StartCoroutine (Wait (1.0F));

		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Humanbullet") {
			effect ();
			takedamage (1, 1);
			audio [1].Play ();
			print (hitmanhealth);
		} else if (col.gameObject.tag == "AlienBullet") {
			effect ();
			audio [1].Play ();
			takedamage (2, 3);
			print (hitmanhealth);
		} else if (col.gameObject.tag == "Car") {
			effect ();
			audio [1].Play ();
			takedamage (3, 3);
		} else if (col.gameObject.tag == "HitmanBomb") {
			audio [1].Play ();
			takedamage (3, 5);
		}
	}

	void effect ()
	{
		Instantiate (deathparticle, gameObject.transform.position, gameObject.transform.rotation);
		Instantiate (bloodeffect, gameObject.transform.position, gameObject.transform.rotation);
	}

	void takedamage (int damageone, int damagetwo)
	{
		if (sceneName == "MainGame") {
			if (hitmanhealth > damageone) {
				hitmanhealth -= damageone;
			} else {
				hitmanhealth = 0;
				audio [0].Play ();
			}
		} else {
			count++;
			if (count == 5) {
				count = 0;
				if (hitmanhealth > damagetwo) {
					hitmanhealth -= damagetwo;
				} else {
					hitmanhealth = 0;
					audio [0].Play ();
				}
				//print (count);
			}
		}
	}
}
