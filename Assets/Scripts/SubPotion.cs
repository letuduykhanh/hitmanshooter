using UnityEngine;
using System.Collections;

public class SubPotion : MonoBehaviour
{
	private PotionShow potionshow;
	private KillHitman killhitman;
	// Use this for initialization
	void Start ()
	{
		potionshow = GameObject.FindGameObjectWithTag ("PotionReward").GetComponent<PotionShow> ();
		killhitman = GameObject.FindGameObjectWithTag ("KillHitman").GetComponent<KillHitman> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void subpotion ()
	{
		int thongminhqua;
		if (potionshow.value > 0 && killhitman.hitmanhealth > 0 && killhitman.hitmanhealth < 20) {
			thongminhqua = 20 - killhitman.hitmanhealth;
			if (thongminhqua > 5) {
				killhitman.hitmanhealth += 5;
			} else {
				killhitman.hitmanhealth += thongminhqua;
			}
			potionshow.value--;
		}
	}
}
