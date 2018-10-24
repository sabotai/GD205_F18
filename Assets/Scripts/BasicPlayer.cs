using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayer : MonoBehaviour {

	Rigidbody myBody;
	public float forceAmt;
	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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

	void OnTriggerStay(Collider col){
		transform.localScale *= 1.01f;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag("playable")){
			if (transform.lossyScale.sqrMagnitude > col.transform.lossyScale.sqrMagnitude ){
				col.gameObject.SetActive(false);
			} else {
				gameObject.SetActive(false);
			}
		}
	}

}
