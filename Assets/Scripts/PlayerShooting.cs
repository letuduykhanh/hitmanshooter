using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{

	public Vector3 bulletOffset = new Vector3 (0.1f, 0.5f, 0);
	public GameObject[] bulletPrefab;
	public GameObject grenade;
	private float fireDelay = 0.5f;
	private float bombDelay = 0.5f;
	public bool death = false;
	public bool pause = false;
	private SubBullet maincamera;
	private Animator animator;
	int bulletLayer;
	float cooldownTimer = 0;
	float cooldownTimerbomb = 0;
	Vector3 offset;

	private LaserOne one;
	private LaserTwo two;
	private LaserThree three;
	private LaserFour four;
	private LaserFive five;
	private LaserSix six;

	public AudioSource shootingsound;

	void Start ()
	{
		maincamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<SubBullet> ();
		bulletLayer = gameObject.layer;
		animator = gameObject.GetComponent<Animator> ();
		one = GameObject.FindGameObjectWithTag ("LaserOne").GetComponent<LaserOne> ();
		two = GameObject.FindGameObjectWithTag ("LaserTwo").GetComponent<LaserTwo> ();
		three = GameObject.FindGameObjectWithTag ("LaserThree").GetComponent<LaserThree> ();
		four = GameObject.FindGameObjectWithTag ("LaserFour").GetComponent<LaserFour> ();
		five = GameObject.FindGameObjectWithTag ("LaserFive").GetComponent<LaserFive> ();
		six = GameObject.FindGameObjectWithTag ("LaserSix").GetComponent<LaserSix> ();
	}

	// Update is called once per frame
	void Update ()
	{
		cooldownTimer -= Time.deltaTime;

		cooldownTimerbomb -= Time.deltaTime;

		if (Input.GetButton ("Fire1") && death == false && pause == false) {
			animator.Play ("hitman_bangsung");
			if (cooldownTimer <= 0) {
				cooldownTimer = fireDelay;

				offset = transform.rotation * bulletOffset;
				if (maincamera.normalbullet == true) {
					ShootBullet (0, 0.5f);
				} else if (maincamera.laserone == true) {
					if (one.value > 0) {
						ShootBullet (1, 0.5f);
						one.value--;
					} else {
						ShootBullet (0, 0.5f);
					}

				} else if (maincamera.lasertwo == true) {
					if (two.value > 0) {
						ShootBullet (2, 0.5f);
						two.value--;
					} else {
						ShootBullet (3, 0.5f);
					}
				} else if (maincamera.laserthree == true) {
					if (three.value > 0) {
						ShootBullet (3, 0.4f);
						three.value--;
					} else {
						ShootBullet (0, 0.5f);
					}
				} else if (maincamera.laserfour == true) {
					if (four.value > 0) {
						ShootBullet (4, 0.3f);
						four.value--;
					} else {
						ShootBullet (0, 0.5f);
					}
				} else if (maincamera.laserfive == true) {
					if (five.value > 0) {
						ShootBullet (5, 0.2f);
						five.value--;
					} else {
						ShootBullet (0, 0.5f);
					}
				} else if (maincamera.lasersix == true) {
					if (six.value > 0) {
						ShootBullet (6, 0.1f);
						six.value--;
					} else {
						ShootBullet (0, 0.5f);
					}
				} 
			}
			// SHOOT!
		} else {
			animator.Play ("hitman_dungim");
		}

		if (Input.GetButton ("Fire2") && death == false) {
			if (cooldownTimerbomb <= 0) {
				cooldownTimerbomb = bombDelay;
				throwbomb ();
			}
		}
	}

	void ShootBullet (int index, float delay)
	{
		shootingsound.Play ();
		fireDelay = delay;
		GameObject bulletGO = (GameObject)Instantiate (bulletPrefab [index], transform.position + offset, transform.rotation);
		bulletGO.layer = bulletLayer;
	}

	void throwbomb ()
	{
		Vector3 offset = transform.rotation * bulletOffset;
		Instantiate (grenade, transform.position + offset, transform.rotation);
	}
}
