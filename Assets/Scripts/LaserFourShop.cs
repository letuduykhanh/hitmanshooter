using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserFourShop : MonoBehaviour
{

	private LaserFour four;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		four = GameObject.FindGameObjectWithTag ("LaserFour").GetComponent<LaserFour> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = four.value + " " + "- 1";
	}
}
