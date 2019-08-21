using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

	Text showscore;
	private ShowScore show;

	// Use this for initialization
	void Start () {
		showscore = gameObject.GetComponent<Text>();
		show = GameObject.FindGameObjectWithTag ("PlayerScore").GetComponent<ShowScore> ();


	}

	// Update is called once per frame
	void Update () {
		showscore.text = "" + show.value;
	}
}
