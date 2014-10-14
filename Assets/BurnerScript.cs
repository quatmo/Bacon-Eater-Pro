using UnityEngine;
using System.Collections;

public class BurnerScript : MonoBehaviour {
    public string burnerState;
    int state;
	// Use this for initialization
	void Start () {
        burnerState = "on";
        state = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.A))
        {
            ChangeBurnerState();
        }
    }
    public void ChangeBurnerState()
    {
        state += 1;
        if (state > 2)
            state = 0;

        if (state == 0)
            burnerState = "off";
        if (state == 1)
            burnerState = "on";
        if (state == 2)
            burnerState = "high";


    }
}
