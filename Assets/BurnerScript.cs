using UnityEngine;
using System.Collections;

public class BurnerScript : MonoBehaviour {
    public string burnerState;
    int state;
    SpriteRenderer burnerSprite;
	// Use this for initialization
	void Start () {
        burnerState = "on";
        state = 1;
        burnerSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.A))
        {
            ChangeBurnerState();
        }
        BurnerColorChange();

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
    void BurnerColorChange()
    {
        
        if (burnerState == "off")
        {
            burnerSprite.color = new Color(1f, 1f, 1f);
        }
        else if (burnerState == "on")
        {
            burnerSprite.color = new Color(1f, 0.75f, 0.75f);
        }
        else if (burnerState == "high")
        {
            burnerSprite.color = new Color(1f, 0.5f, 0.5f);
        }
    }
}
