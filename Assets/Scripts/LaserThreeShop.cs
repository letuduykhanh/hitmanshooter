using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserThreeShop : MonoBehaviour
{
	private LaserThree three;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		three = GameObject.FindGameObjectWithTag ("LaserThree").GetComponent<LaserThree> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = three.value + " " + "- 1";
	}
}
