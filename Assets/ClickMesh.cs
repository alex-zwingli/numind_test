using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ClickMesh : MonoBehaviour, IInputClickHandler {

    public Animator anim;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Input detectged");
        if (anim != null)
        {
            if (anim.GetBool("Paused"))
                anim.SetBool("Paused", false);
            else
                anim.enabled = !anim.enabled;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
