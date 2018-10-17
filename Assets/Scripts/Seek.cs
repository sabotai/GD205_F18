using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {

	Rigidbody myBody;
	public Transform target;
	public float forceAmt;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.Normalize(target.position - transform.position);

		myBody.AddForce(direction * forceAmt);
		
	}
}
