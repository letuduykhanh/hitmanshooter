using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaserFive : MonoBehaviour {
	public int value;
	private Text showscore;
	// Use this for initialization
	void Start () {
		showscore = gameObject.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		showscore.text = "" + value;
	}
}
