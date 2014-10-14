using UnityEngine;
using System.Collections;

public class CustomerAnimatorScript : MonoBehaviour {
    public Animator animator;
    float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bacon")
        {
            animator.SetBool("isChewing", true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bacon")
        {
            animator.SetBool("isChewing", false);
        }
    }
    void StopChewing()
    {
            animator.SetBool("isChewing", false);
    }
}
