using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFirstTouch : MonoBehaviour {

    public GameObject attractor;
    private Animator anim;

	void Start ()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }
	
	
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("onTouch", true);
            
        }

        if (Input.touchCount > 1 || Input.GetMouseButtonDown(1))
        {
            anim.SetBool("onTouch", false);
        }
	}

    public void RemoveAnimator()
    {
        Destroy(this.gameObject.GetComponent<Animator>());
        attractor.GetComponent<Attractor>().enabled = true;
        Destroy(this.gameObject, 3);
    }
}
