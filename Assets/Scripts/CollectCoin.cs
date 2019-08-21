using UnityEngine;
using System.Collections;

public class CollectCoin : MonoBehaviour
{
	
	public GameObject parent;
	// Use this for initialization
	void Start ()
	{
		parent = this.transform.parent.gameObject;
	}

	IEnumerator Wait (float waitTime)
	{
		parent.GetComponent<Animator> ().Play ("ParticleCoinCollect");
		yield return new WaitForSeconds (waitTime);
		Destroy (transform.parent.gameObject);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			StartCoroutine (Wait (0.7f));
		}
	}
}
