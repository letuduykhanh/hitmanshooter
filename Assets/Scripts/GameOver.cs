using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public GameObject gameover;
	private KillHitman killhitman;

	// Use this for initialization
	void Start () {
		gameover.SetActive (false);
		killhitman = GameObject.FindGameObjectWithTag ("KillHitman").GetComponent<KillHitman> ();
	}

	IEnumerator wait(float time){
		yield return new WaitForSeconds (time);
		gameover.SetActive (true);
		yield return new WaitForSeconds (time);
		Time.timeScale = 0;
			

	}

	// Update is called once per frame
	void Update () {
		if (killhitman.death == true) {
			StartCoroutine (wait(2));
		}
		//Debug.Log(SceneManager.GetActiveScene().name);
	}

	public void retry(){
		Time.timeScale = 1;
		string sceneName = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (sceneName,LoadSceneMode.Single);
	}

	public void no(){
		Time.timeScale = 1;
		SceneManager.LoadScene ("Start");
	}
}
