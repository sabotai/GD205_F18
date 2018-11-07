using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAnim : MonoBehaviour {

	Animator myAnim;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		myAnim.SetInteger("state", 0);
		if (Input.GetKeyDown(KeyCode.Space)){
			myAnim.SetInteger("state", 1);
		}
	}
}
