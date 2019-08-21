using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour
{
	
	public Vector3 bulletOffset = new Vector3 (0.5f, -0.1f, 10.0f);
	public GameObject[] bulletPrefab;
	public bool death = false;
	int bulletLayer;

	public float fireDelay = 0.25f;
	public float cooldownTimer = 0;
	public AudioSource[] sounds;

	private FollowPlayer followplayer;
	private int randombullet;
	private int randomsound;

	// Use this for initialization
	void Start ()
	{
		followplayer = gameObject.GetComponentInParent<FollowPlayer> ();
		bulletLayer = gameObject.layer;
		randombullet = Random.Range (0, 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
		cooldownTimer -= Time.deltaTime;

		if (followplayer.phathienvacham == true && followplayer.laplayer == true && followplayer.target != null) {
			
			if (death == false) {
				if (Vector3.Distance (transform.position, followplayer.target.position) <= 2.5f) {
					if (cooldownTimer <= 0) {
						cooldownTimer = fireDelay;
						Vector3 offset = transform.rotation * bulletOffset;

						if (gameObject.tag == "Robot" || gameObject.tag == "Alien") {
							GameObject bulletGO = (GameObject)Instantiate (bulletPrefab [randombullet], transform.position + offset, transform.rotation);
							bulletGO.layer = bulletLayer;
							shoot ();
						} else {
							GameObject bulletGO = (GameObject)Instantiate (bulletPrefab [0], transform.position + offset, transform.rotation);
							bulletGO.layer = bulletLayer;
							shoot ();
						}
					}
				}
			}
		}
	}

	void shoot ()
	{
		if (gameObject.tag == "Robot") {
			randomsound = Random.Range (0, 1);
			sounds [randomsound].Play ();
		} else {
			sounds [0].Play ();
		}
	}
}
