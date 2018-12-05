using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour {

	Text myText;
	public float timerAmt = 5f;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "" + (timerAmt - Time.time);
	}
}
