using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserSixShop : MonoBehaviour
{

	private LaserSix six;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		six = GameObject.FindGameObjectWithTag ("LaserSix").GetComponent<LaserSix> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = six.value + " " + "- 1";
	}
}
