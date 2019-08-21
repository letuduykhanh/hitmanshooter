using UnityEngine;
using System.Collections;

public class SubBullet : MonoBehaviour
{

	public bool normalbullet;
	public bool laserone;
	public bool lasertwo;
	public bool laserthree;
	public bool laserfour;
	public bool laserfive;
	public bool lasersix;


	// Use this for initialization
	void Start ()
	{
		normalbullet = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void normal ()
	{
		normalbullet = true;
		laserone = false;
		lasertwo = false;
		laserthree = false;
		laserfour = false;
		laserfive = false;
		lasersix = false;
	}

	public void LaserOne ()
	{
		normalbullet = false;
		laserone = true;
		lasertwo = false;
		laserthree = false;
		laserfour = false;
		laserfive = false;
		lasersix = false;
	}

	public void LaserTwo ()
	{
		normalbullet = false;
		laserone = false;
		lasertwo = true;
		laserthree = false;
		laserfour = false;
		laserfive = false;
		lasersix = false;
	}

	public void LaserThree ()
	{
		normalbullet = false;
		laserone = false;
		lasertwo = false;
		laserthree = true;
		laserfour = false;
		laserfive = false;
		lasersix = false;
	}

	public void LaserFour ()
	{
		normalbullet = false;
		laserone = false;
		lasertwo = false;
		laserthree = false;
		laserfour = true;
		laserfive = false;
		lasersix = false;
	}

	public void LaserFive ()
	{
		normalbullet = false;
		laserone = false;
		lasertwo = false;
		laserthree = false;
		laserfour = false;
		laserfive = true;
		lasersix = false;
	}

	public void LaserSix ()
	{
		normalbullet = false;
		laserone = false;
		lasertwo = false;
		laserthree = false;
		laserfour = false;
		laserfive = false;
		lasersix = true;
	}
}
