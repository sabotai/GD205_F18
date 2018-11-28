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
		myBody.velocity = Vector3.zero;
		if (Input.GetKey(KeyCode.W)){
			myBody.AddForce(transform.forward * forceAmt);
		}
		if (Input.GetKey(KeyCode.S)){
			myBody.AddForce(-transform.forward * forceAmt);
		}
		if (Input.GetKey(KeyCode.A)){
			myBody.AddForce(-transform.right * forceAmt);
		}
		if (Input.GetKey(KeyCode.D)){
			myBody.AddForce(transform.right * forceAmt);
		}
	}
}
