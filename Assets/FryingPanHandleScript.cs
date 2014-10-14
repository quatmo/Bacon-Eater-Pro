using UnityEngine;
using System.Collections;

public class FryingPanHandleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
        
	}

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(mousePosition.x, mousePosition.y);
        //gameObject.transform.parent.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y);
    }
}
