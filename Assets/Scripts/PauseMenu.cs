using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

	public GameObject pausemenu;
	public GameObject pausebutton;
	public bool paused;
	private PlayerShooting playershooting;
	private PlayerMovement playermovement;

	// Use this for initialization
	void Start ()
	{
		pausemenu.SetActive (false);
		playershooting = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerShooting> ();
		playermovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void pause ()
	{
		paused = true;
		if (paused == true) {
			pausemenu.SetActive (true);
			pausebutton.SetActive (false);
			playershooting.pause = true;
			playermovement.pause = true;
			Time.timeScale = 0;
		}
	}

	public void play ()
	{
		paused = false;
		if (paused == false) {
			pausemenu.SetActive (false);
			pausebutton.SetActive (true);
			playershooting.pause = false;
			playermovement.pause = false;
			Time.timeScale = 1;
		} 
	}

	public void restart ()
	{
		string sceneName = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
		Time.timeScale = 1;
	}

	public void mainmenu ()
	{
		SceneManager.LoadScene ("Start");
		Time.timeScale = 1;
	}

	public void exitgame ()
	{
		Application.Quit ();
	}
}
