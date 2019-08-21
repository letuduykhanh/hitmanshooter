using UnityEngine;
using System.Collections;

public class ItemsShop : MonoBehaviour
{
	public GameObject pause;
	public GameObject shopmenu;
	public GameObject shopchild;
	public GameObject bulletsmenu;
	public GameObject buttonshow;
	public GameObject buttonhide;
	public bool paused;
	private PlayerShooting playershooting;
	private PlayerMovement playermovement;

	private ShowCoin showcoin;
	private LaserOne one;
	private LaserTwo two;
	private LaserThree three;
	private LaserFour four;
	private LaserFive five;
	private LaserSix six;
	private PotionShow potionshow;

	// Use this for initialization
	void Start ()
	{
		shopmenu.SetActive (false);
		playershooting = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerShooting> ();
		playermovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();
		showcoin = GameObject.FindGameObjectWithTag ("PlayerCoin").GetComponent<ShowCoin> ();
		one = GameObject.FindGameObjectWithTag ("LaserOne").GetComponent<LaserOne> ();
		two = GameObject.FindGameObjectWithTag ("LaserTwo").GetComponent<LaserTwo> ();
		three = GameObject.FindGameObjectWithTag ("LaserThree").GetComponent<LaserThree> ();
		four = GameObject.FindGameObjectWithTag ("LaserFour").GetComponent<LaserFour> ();
		five = GameObject.FindGameObjectWithTag ("LaserFive").GetComponent<LaserFive> ();
		six = GameObject.FindGameObjectWithTag ("LaserSix").GetComponent<LaserSix> ();
		potionshow = GameObject.FindGameObjectWithTag ("PotionReward").GetComponent<PotionShow> ();
		//bombs = GameObject.FindGameObjectWithTag ("BombReward").GetComponent<Bomb> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	IEnumerator waitshop (float time)
	{
		pause.SetActive (false);
		shopmenu.SetActive (true);
		yield return new WaitForSeconds (time);
		shopchild.GetComponent<Animator> ().Play ("ShowItems");
		yield return new WaitForSeconds (0.8f);
		Time.timeScale = 0;
	}

	IEnumerator waitplay (float time)
	{
		Time.timeScale = 1;
		yield return new WaitForSeconds (time);
		shopchild.GetComponent<Animator> ().Play ("HideItems");
		yield return new WaitForSeconds (0.8f);
		pause.SetActive (true);
		shopmenu.SetActive (false);

	}

	public void shop ()
	{
		StartCoroutine (waitshop (0.2f));
		playershooting.pause = true;
		playermovement.pause = true;

	}

	public void bplay ()
	{
		StartCoroutine (waitplay (0.2f));
		playershooting.pause = false;
		playermovement.pause = false;
	}

	public void bLaserOne ()
	{
		if (showcoin.value >= 1) {
			one.value += 1;
			showcoin.value -= 1;
		}

	}

	public void sLaserOne ()
	{
		if (one.value >= 1) {
			one.value -= 1;
			showcoin.value += 1;
		}

	}

	public void bLaserTwo ()
	{
		if (showcoin.value >= 1) {
			two.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sLaserTwo ()
	{
		if (two.value >= 1) {
			two.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bLaserThree ()
	{
		if (showcoin.value >= 1) {
			three.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sLaserThree ()
	{
		if (three.value >= 1) {
			three.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bLaserFour ()
	{
		if (showcoin.value >= 1) {
			four.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sLaserFour ()
	{
		if (four.value >= 1) {
			four.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bLaserFive ()
	{
		if (showcoin.value >= 1) {
			five.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sLaserFive ()
	{
		if (five.value >= 1) {
			five.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bLaserSix ()
	{
		if (showcoin.value >= 1) {
			six.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sLaserSix ()
	{
		if (six.value >= 1) {
			six.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bBomb ()
	{
		if (showcoin.value >= 1) {
			one.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sBomb ()
	{
		if (one.value >= 1) {
			one.value -= 1;
			showcoin.value += 1;
		}
	}

	public void bPotion ()
	{
		if (showcoin.value >= 1) {
			potionshow.value += 1;
			showcoin.value -= 1;
		}
	}

	public void sPotion ()
	{
		if (potionshow.value >= 1) {
			potionshow.value -= 1;
			showcoin.value += 1;
		}
	}

	public void showitems ()
	{
		buttonhide.SetActive (true);
		buttonshow.SetActive (false);
		bulletsmenu.GetComponent<Animator> ().SetBool ("Show", true);
	}

	public void hideitems ()
	{
		buttonhide.SetActive (false);
		buttonshow.SetActive (true);
		bulletsmenu.GetComponent<Animator> ().SetBool ("Show", false);
	}
}
