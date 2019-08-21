using UnityEngine;
using System.Collections;

public class BoxEffect : MonoBehaviour {

	public GameObject parent;
	// Use this for initialization
	void Start () {
		parent = this.transform.parent.gameObject;
	}
	
	IEnumerator Wait(float waitTime) {
		Destroy (gameObject);

		parent.GetComponent<Animator> ().Play ("box");
		yield return new WaitForSeconds(waitTime);


	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		////if (col.gameObject.tag == "HitmanNormalbullet") {
			//StartCoroutine(Wait(1.0F));
		//}
	}
}
