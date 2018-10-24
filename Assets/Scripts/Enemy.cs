using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	Rigidbody myBody;
	Material myMat;

	//assign the target in the inspector
	public Transform target;

	//we use a forceAmt so we can multiply the direction and it will affect all axes the same
	public float forceAmt;

	// Use this for initialization
	void Start () {
		//assign whichever rigidbody is attached to this gameobject
		myBody = GetComponent<Rigidbody>();
		myMat = GetComponent<MeshRenderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		//we can use the 2 positions to determine the distance apart
		//Vector3.Normalize will convert this into a direction (a vector3 with x/y/z values between -1 and 1)
		Vector3 direction;

		//we are using an if statement to compare the scale of the gameobject this is attached to
		//versus our targets scale
		//lossyScale refers to the global scale and sqrMagnitude refers to the general scale
		if (transform.lossyScale.sqrMagnitude > target.lossyScale.sqrMagnitude ){
			//if our scale is larger than the targets, then seek the player
			direction = Vector3.Normalize(target.position - transform.position);
			//also update the color of our material to red (threatening)
			myMat.color = Color.red;
		} else {
			//if our scale is smaller than the targets, then run away from the player
			direction = Vector3.Normalize(transform.position - target.position);
			//also update the color of our material to green (edible)
			myMat.color = Color.green;
		}
		//constantly adding force in the direction (either towards or away from)
		//multiplied by an amount (forceAmt)
		myBody.AddForce(direction * forceAmt);
		
	}
}
