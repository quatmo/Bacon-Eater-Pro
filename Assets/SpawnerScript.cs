using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	public GameObject objectToSpawn;
	//public bool directionIsLeft;
	public float timeToSpawn; //Time it takes to spawn a new object. 
	float spawnTimer;
	public Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
		spawnTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		SpawnTimer ();
	}

	void SpawnTimer()
	{
		spawnTimer += Time.deltaTime;
		if (spawnTimer > timeToSpawn)
		{
			Spawn();
			spawnTimer = 0f;
		}
	}

	void Spawn () {
		GameObject spawnedObject = (GameObject)Instantiate(objectToSpawn, spawnPosition, new Quaternion(0f,0f,0f,0f));
	}
}
