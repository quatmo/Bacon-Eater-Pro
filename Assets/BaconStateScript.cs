using UnityEngine;
using System.Collections;

public class BaconStateScript : MonoBehaviour {
    public string baconState;
    public float timeInPan;
	// Use this for initialization
	void Start () {
        baconState = "raw";
        timeInPan = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if (baconState == "chewy")
        {

        }
        else if (baconState == "crispy")
        {

        }
        else if (baconState == "burnt")
        {

        }
	}

    void CheckBaconState()
    {
        if (timeInPan >= 30)
        {
            baconState = "chewy";
        }
        else if (timeInPan >= 60)
        {
            baconState = "crispy";
        }
        else if (timeInPan >= 90)
        {
            baconState = "burnt";
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Frying Pan")
        {
            timeInPan += Time.deltaTime;
        }
    }
}
