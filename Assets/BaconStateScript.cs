using UnityEngine;
using System.Collections;

public class BaconStateScript : MonoBehaviour
{
    public string baconState;
    public float timeInPan;
    float baconTimeModifier;
    public Sprite rawBacon;
    public Sprite chewyBacon;
    public Sprite crispyBacon;
    public Sprite burntBacon;
    SpriteRenderer spriteRender;
    // Use this for initialization
    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
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
            spriteRender.sprite = chewyBacon;
        }
        else if (baconState == "crispy")
        {
            spriteRender.sprite = crispyBacon;
        }
        else if (baconState == "burnt")
        {
            spriteRender.sprite = burntBacon;
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
            GameObject fryingPan = col.gameObject;
            float temperatureModifier = fryingPan.GetComponent<FryingPanScript>().temperatureModifier;
            Debug.Log("Bacon Staying In Pan");
            timeInPan += Time.deltaTime * temperatureModifier;
        }
    }
}
