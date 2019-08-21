using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighCoin : MonoBehaviour {

	Text showcoin;
	private ShowCoin show;

	// Use this for initialization
	void Start () {
		showcoin = gameObject.GetComponent<Text>();
		show = GameObject.FindGameObjectWithTag ("PlayerCoin").GetComponent<ShowCoin> ();


	}

	// Update is called once per frame
	void Update () {
		showcoin.text = "" + show.value;
	}
}
