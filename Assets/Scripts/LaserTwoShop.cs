using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserTwoShop : MonoBehaviour
{

	private LaserTwo two;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		two = GameObject.FindGameObjectWithTag ("LaserTwo").GetComponent<LaserTwo> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = two.value + " " + "- 1";
	}
}
