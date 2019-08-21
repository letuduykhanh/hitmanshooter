using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
	//public int bomb;
	private ShowCoin showcoin;
	private LaserOne one;
	private LaserTwo two;
	private LaserThree three;
	private LaserFour four;
	private LaserFive five;
	private LaserSix six;
	private PotionShow potionshow;
	private string scenename;
	public AudioSource audio;
	//private Bomb bombs;


	// Use this for initialization
	void Start ()
	{
		showcoin = GameObject.FindGameObjectWithTag ("PlayerCoin").GetComponent<ShowCoin> ();
		one = GameObject.FindGameObjectWithTag ("LaserOne").GetComponent<LaserOne> ();
		two = GameObject.FindGameObjectWithTag ("LaserTwo").GetComponent<LaserTwo> ();
		three = GameObject.FindGameObjectWithTag ("LaserThree").GetComponent<LaserThree> ();
		four = GameObject.FindGameObjectWithTag ("LaserFour").GetComponent<LaserFour> ();
		five = GameObject.FindGameObjectWithTag ("LaserFive").GetComponent<LaserFive> ();
		six = GameObject.FindGameObjectWithTag ("LaserSix").GetComponent<LaserSix> ();
		potionshow = GameObject.FindGameObjectWithTag ("PotionReward").GetComponent<PotionShow> ();
		//bombs = GameObject.FindGameObjectWithTag ("BombReward").GetComponent<Bomb> ();
		scenename = SceneManager.GetActiveScene ().name;
		if (scenename == "Survivor") {
			one.value += 20;
			two.value += 20;
			three.value += 20;
			four.value += 20;
			five.value += 20;
			six.value += 20;
			potionshow.value += 3;
		}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Coin") {
			showcoin.value++;
			playsound ();
		} else if (col.gameObject.tag == "LaserOneReward") {
			one.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "LaserTwoReward") {
			two.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "LaserThreeReward") {
			three.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "LaserFourReward") {
			four.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "LaserFiveReward") {
			five.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "LaserSixReward") {
			six.value += 20;
			playsound ();
		} else if (col.gameObject.tag == "Bomb") {
			//bombs.value += 20;
		} else if (col.gameObject.tag == "Potion") {
			potionshow.value += 1;
			playsound ();
		}
	}

	void playsound ()
	{
		audio.Play ();
	}
}
