using UnityEngine;
using System.Collections;

public class BaconMovementScript : MonoBehaviour {
    public bool onFace;
    GameObject customer;
	// Use this for initialization
	void Start () {
        onFace = false;
        customer = GameObject.FindGameObjectWithTag("Customer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(mousePosition.x, mousePosition.y);

    }

    void OnMouseUp()
    {
       if (onFace == true)
       {
           customer.SendMessage("StopChewing");
           Destroy(gameObject);
       }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Customer")
        {
            onFace = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Customer")
        {
            onFace = false;
        }
    }
}
