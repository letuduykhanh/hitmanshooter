using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour
{

	public GameObject parent;
	public GameObject deathparticle;
	public GameObject bloodeffect;
	public GameObject[] reward;
	private EnemyShooting enemyshooting;
	private FollowPlayer followplayer;
	private string enemytype;
	private int humanhealth = 6;
	private int zombiehealth = 12;
	public int robothealth = 24;
	private int alienhelth = 48;
	private Animator anim;
	private ShowScore showscore;
	private int randomreward;
	public AudioSource[] screams;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponentInParent<Animator> ();
		enemyshooting = gameObject.GetComponentInParent<EnemyShooting> ();
		followplayer = gameObject.GetComponentInParent<FollowPlayer> ();
		showscore = GameObject.FindGameObjectWithTag ("PlayerScore").GetComponent<ShowScore> ();
		randomreward = Random.Range (0, 19);
	}

	IEnumerator Wait (float waitTime)
	{
		
		if (parent != null) {
			parent.GetComponent<Animator> ().enabled = true;
		}
		yield return new WaitForSeconds (waitTime);
		Destroy (transform.parent.gameObject);

	}

	
	// Update is called once per frame
	void Update ()
	{
		if (humanhealth == 0) {
			kill ();
		}

		if (robothealth == 0) {
			kill ();
		}

		if (zombiehealth == 0) {
			kill ();
		}

		if (alienhelth == 0) {
			kill ();
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "HitmanNormalbullet") {
			takedamage (1);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser01") {
			takedamage (2);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser02") {
			takedamage (3);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser03") {
			takedamage (4);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser04") {
			takedamage (5);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser05") {
			takedamage (6);
			DetroyEffect ();
		} else if (col.gameObject.tag == "Laser06") {
			takedamage (7);
			DetroyEffect ();
		} else if (col.gameObject.tag == "HitmanBomb") {
			takedamage (20);
			DetroyEffect ();
		}
	}

	void DetroyEffect ()
	{
		Instantiate (deathparticle, gameObject.transform.position, gameObject.transform.rotation);
		Instantiate (bloodeffect, gameObject.transform.position, gameObject.transform.rotation);
	}

	void ApplyDamage (int damage)
	{
		if (gameObject.tag == "Human") {
			if (damage > humanhealth) {
				humanhealth = 0;
			} else {
				humanhealth = humanhealth - damage;
			}
			if (humanhealth == 0) {
				showscore.value += 100;
				randomReward ();
				screams [0].Play ();
			} else {
				screams [1].Play ();
			}
			print (humanhealth);
		} else if (gameObject.tag == "Zombie") {
			if (damage > zombiehealth) {
				zombiehealth = 0;
			} else {
				zombiehealth = zombiehealth - damage;
			}
			if (zombiehealth == 0) {
				showscore.value += 200;
				randomReward ();
				screams [0].Play ();
			} else {
				screams [1].Play ();
			}
			print (zombiehealth);
		} else if (gameObject.tag == "Robot") {
			if (damage > robothealth) {
				robothealth = 0;
			} else {
				robothealth = robothealth - damage;
			}
			if (robothealth == 0) {
				showscore.value += 300;
				randomReward ();
				screams [1].Play ();
			} else {
				screams [0].Play ();
			}
			print (robothealth);
		} else if (gameObject.tag == "Alien") {
			if (damage > alienhelth) {
				alienhelth = 0;
			} else {
				alienhelth = alienhelth - damage;
			}
			if (alienhelth == 0) {
				showscore.value += 400;
				randomReward ();

			} else {
				
			}
			print (alienhelth);
		}
	}

	void randomReward ()
	{
		gameObject.GetComponent<Collider2D> ().enabled = false;
		if (randomreward == 0) {
			Instantiate (reward [randomreward], gameObject.transform.position, reward [randomreward].transform.rotation);
		} else {
			Instantiate (reward [randomreward], gameObject.transform.position, gameObject.transform.rotation);
		}
	}

	void kill ()
	{
		anim.SetBool ("Death", true);
		followplayer.death = true;
		enemyshooting.death = true;
		StartCoroutine (Wait (2.0F));
	}

	void takedamage (int damage)
	{
		gameObject.GetComponent<Collider2D> ().SendMessage ("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
	}
}