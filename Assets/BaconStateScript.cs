using UnityEngine;
using System.Collections;

public class BaconStateScript : MonoBehaviour
{
    public string baconState;
    public float timeInPan;
    float baconTimeModifier;
    // Use this for initialization
    void Start()
    {
        baconState = "raw";
        timeInPan = 0;
        baconTimeModifier = Random.RandomRange(1f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        CheckBaconState();
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
        if (timeInPan >= 30 - baconTimeModifier)
        {
            baconState = "chewy";
        }
        if (timeInPan >= 60 - baconTimeModifier)
        {
            baconState = "crispy";
        }
        if (timeInPan >= 90 - baconTimeModifier)
        {
            baconState = "burnt";
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "Frying Pan")
        {
            Debug.Log("Bacon Staying In Pan");
            timeInPan += Time.deltaTime;
        }
    }
}
