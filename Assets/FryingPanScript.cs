using UnityEngine;
using System.Collections;

public class FryingPanScript : MonoBehaviour {
    public float temperatureModifier;
    public GameObject burner;
    public string burnState;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        burnState = burner.GetComponent<BurnerScript>().burnerState;

        if (burnState == "off")
        {
            temperatureModifier = 0f;
        }
        if (burnState == "on")
        {
            temperatureModifier = 1f;
        }
        if (burnState == "high")
        {
            temperatureModifier = 1.5f;
        }
	}

    

    
}
