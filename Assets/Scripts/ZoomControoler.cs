using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControoler : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = gameObject.GetComponent<Animator>();	
	}

    public void ZoomIn()
    {
        anim.SetTrigger("ZoomIn");
    }

    public void ZoomOut()
    {
        anim.SetTrigger("ZoomOut");
    }
}
