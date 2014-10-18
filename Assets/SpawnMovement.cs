using UnityEngine;
using System.Collections;

public class SpawnMovement : MonoBehaviour {
	public float timeBetweenMoves;
	public float timer;
	public bool moveLeft;
	public float moveDistance; 
	// Use this for initialization
	void Start () {
		moveLeft = true;
	}
	
	// Update is called once per frame
	void Update () {
		MoveTimer();
	}

	void MoveTimer()
	{
		timer += Time.deltaTime;
		if (timer >= timeBetweenMoves)
		{
			Move ();
			timer = 0f;
		}
	}

	void Move () {
		if (moveLeft)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x - moveDistance, 
			                                            gameObject.transform.position.y,
			                                            gameObject.transform.position.z);
		}
		else 
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x + moveDistance, 
			                                            gameObject.transform.position.y,
			                                            gameObject.transform.position.z);
		}
	}

	void MoveLeft () {
		moveLeft = true;
	}

	void MoveRight () {
		moveLeft = false;
	}
}
