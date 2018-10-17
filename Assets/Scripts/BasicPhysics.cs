using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPhysics : MonoBehaviour {

	Rigidbody myBody;
	public float forceAmt;
	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
			myBody.AddForce(Vector3.forward * forceAmt);
		}
		if (Input.GetKey(KeyCode.S)){
			myBody.AddForce(Vector3.back * forceAmt);
		}
		if (Input.GetKey(KeyCode.A)){
			myBody.AddForce(Vector3.left * forceAmt);
		}
		if (Input.GetKey(KeyCode.D)){
			myBody.AddForce(Vector3.right * forceAmt);
		}
	}
}
