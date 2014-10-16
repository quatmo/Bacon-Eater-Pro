using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    public GameObject burner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        burner.SendMessage("ChangeBurnerState");
    }
}
