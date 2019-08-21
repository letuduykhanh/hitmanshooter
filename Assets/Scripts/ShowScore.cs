using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ShowScore : MonoBehaviour
{
	
	public int value;
	private Text showscore;
	private string sceneName;
	public bool win;
	// Use this for initialization
	void Start ()
	{
		showscore = gameObject.GetComponent<Text> ();
		sceneName = SceneManager.GetActiveScene ().name;
	}
	
	// Update is called once per frame
	void Update ()
	{
		showscore.text = "" + value;
		if (sceneName == "MainGame" && value == 800) {
			win = true;
		} //else if (sceneName == "Survivor" && value == 1000) {
		//}
	}
}
