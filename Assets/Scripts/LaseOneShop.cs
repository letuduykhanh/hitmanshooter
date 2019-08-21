using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaseOneShop : MonoBehaviour
{
	private LaserOne one;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		one = GameObject.FindGameObjectWithTag ("LaserOne").GetComponent<LaserOne> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = one.value + " " + "- 1";
	}
}
