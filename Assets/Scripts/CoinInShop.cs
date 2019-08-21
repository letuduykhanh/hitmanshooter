using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinInShop : MonoBehaviour
{
	private ShowCoin showcoin;
	private Text show;
	// Use this for initialization
	void Start ()
	{
		showcoin = GameObject.FindGameObjectWithTag ("PlayerCoin").GetComponent<ShowCoin> ();
		show = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		show.text = "" + showcoin.value;
	}
}
