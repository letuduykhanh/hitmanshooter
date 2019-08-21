using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameObject buttongroup;
	public GameObject credittext;
	public GameObject returnbutton;

	// Use this for initialization
	void Start () {
		credittext.SetActive (false);
		returnbutton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Startgame() {
		SceneManager.LoadScene ("MainGame");

	}

	public void GameOption(){

	}

	public void GameCredit(){
		buttongroup.SetActive (false);
		credittext.SetActive (true);
		returnbutton.SetActive (true);
	}

	public void exitgame(){
		Application.Quit ();
	}

	public void returnMain(){
		buttongroup.SetActive (true);
		credittext.SetActive (false);
		returnbutton.SetActive (false);
	}

}
