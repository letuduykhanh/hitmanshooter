using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PotionShop : MonoBehaviour
{
	private PotionShow potionshow;
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		potionshow = GameObject.FindGameObjectWithTag ("PotionReward").GetComponent<PotionShow> ();
	}

	// Update is called once per frame
	void Update ()
	{
		showscore.text = potionshow.value + " " + "- 1";
	}
}
