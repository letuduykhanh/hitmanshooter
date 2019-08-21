using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCoin : MonoBehaviour {

	Text showvalue;
	public int value;
	void Start () {
		showvalue = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		showvalue.text = "" + value;
	}
}
