using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
	public GameObject[] Enemy;
	public float SpawnTime = 50f;
	private Renderer rd;
	int randomenemy;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("Spawn", SpawnTime, SpawnTime);
		rd = gameObject.GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		randomenemy = Random.Range (0, 8);
	}

	void Spawn ()
	{
		
		float x1 = transform.position.x - rd.bounds.size.x / 2;
		float x2 = transform.position.x + rd.bounds.size.x / 2;
		Vector2 spawnPoint = new Vector2 (Random.Range (x1, x2), transform.position.y);
		Instantiate (Enemy [randomenemy], spawnPoint, Quaternion.identity);
	
	}
}
