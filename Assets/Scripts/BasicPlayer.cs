using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

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

	//OnTriggerStay will run any frame in which our collider is inside of a trigger object (collider marked as trigger in the inspector)
	void OnTriggerStay(Collider col){ //triggers dont cause collisions, which is why we use a collider to keep track on the trigger information
		transform.localScale *= 1.01f; //for every frame in which we are inside the trigger, increase the scale by 1%
	}

	//OnCollisionEnter will run anytime a collision has begun
	void OnCollisionEnter(Collision col){ //it creates a new Collision to store the information about our collision. we called it col.
		if (col.gameObject.CompareTag("playable")){ //we want to check the tag of the thing we collided with (is it "playable"?)
			
			//we compare the scale of the transform of whatever this script is attached to (transform.lossyScale) against the one we collided with
			if (transform.lossyScale.sqrMagnitude > col.transform.lossyScale.sqrMagnitude ){
				//if we are larger, "eat it" (set active to false)
				col.gameObject.SetActive(false);
			} else {
				//otherwise, set us to inactive
				gameObject.SetActive(false);
				//Invoke("reload", 1f);
			}
		}
	}

/*
	void reload(){
		SceneManager.LoadScene(0);
	}
*/
}
