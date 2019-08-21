using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Sprite[] HealthSprites;

	public Image HeathBarUI;
	private KillHitman killhitman;

	// Use this for initialization
	void Start ()
	{
		killhitman = GameObject.FindGameObjectWithTag ("KillHitman").GetComponent<KillHitman> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		HeathBarUI.sprite = HealthSprites [killhitman.hitmanhealth];
	}

}
