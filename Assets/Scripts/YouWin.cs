using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{

	public GameObject win;
	private ShowScore showscore;
	// Use this for initialization
	void Start ()
	{
		win.SetActive (false);
		showscore = GameObject.FindGameObjectWithTag ("PlayerScore").GetComponent<ShowScore> ();
	}

	IEnumerator wait (float time)
	{
		yield return new WaitForSeconds (time);
		win.SetActive (true);
		yield return new WaitForSeconds (time);
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (showscore.win == true) {
			StartCoroutine (wait (2));
		}
	}

	public void retry ()
	{
		Time.timeScale = 1;
		string sceneName = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (sceneName, LoadSceneMode.Single);

	}

	public void no ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("Start");
	}

	public void next ()
	{
		SceneManager.LoadScene ("Survivor");
		Time.timeScale = 1;
	}

	public void home ()
	{
		SceneManager.LoadScene ("Start");
		Time.timeScale = 1;
	}


}
