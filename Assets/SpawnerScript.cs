using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	public GameObject objectToSpawn;
	//public bool directionIsLeft;
	public float timeToSpawn; //Time it takes to spawn a new object. 
	float spawnTimer;
	public Vector3 spawnPosition;
    public bool spawnRandomlyAround;

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
            if (!spawnRandomlyAround)
                Spawn();

            else if (spawnRandomlyAround)
                SpawnRandomlyAround();

			spawnTimer = 0f;
		}
	}

    void SpawnRandomlyAround()
    {
        Random.seed = (int)System.DateTime.Now.ToBinary();
        Vector3 randomLocation = new Vector3(spawnPosition.x + Random.Range(-3f, 3f), spawnPosition.y + Random.Range(-.5f, .5f), 0f);
        GameObject objectSpawned = (GameObject)Instantiate(objectToSpawn, randomLocation, new Quaternion(0f, 0f, 0f, 0f));
    }

	void Spawn () {
        GameObject objectSpawned = (GameObject)Instantiate(objectToSpawn, spawnPosition, new Quaternion(0f, 0f, 0f, 0f));
	}
}
