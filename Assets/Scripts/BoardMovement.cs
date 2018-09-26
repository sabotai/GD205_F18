using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour {

	public float gridSize = 2f;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W) && transform.position.z < 7f) {
			Debug.Log("player pressed the w key");
			transform.position += transform.forward * gridSize;
		}
		if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -7f) {
			Debug.Log("player pressed the a key");
			transform.position += -transform.right * gridSize;
		}
		if (Input.GetKeyDown(KeyCode.S) && transform.position.z > -7f) {
			Debug.Log("player pressed the s key");
			transform.position += -transform.forward * gridSize;
		}
		if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 7f) {
			Debug.Log("player pressed the d key");
			transform.position += transform.right * gridSize;
		}

		if (Input.GetKeyDown(KeyCode.Space)){
			transform.position = startPos;
		}

	}
}
