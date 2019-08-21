﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserFiveShop : MonoBehaviour
{

	private LaserFive five;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		five = GameObject.FindGameObjectWithTag ("LaserFive").GetComponent<LaserFive> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = five.value + " " + "- 1";
	}
}
