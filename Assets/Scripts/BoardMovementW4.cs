using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovementW4 : MonoBehaviour {

	public float gridSize = 2f;
	Vector3 startPos;
	public Transform[] loseSpot;
	public Transform winSpot;
	public TextMesh displayText;


	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	// Update is called once per frame
	void Update () {
		//check if each WASD key is being pressed down
		//AND if it is within the bounds of our grid (for each direction)
		if (Input.GetKeyDown(KeyCode.W) && transform.position.z < 7f) {
			//if the player presses w and they are not on the edge of the board, then move them
			Debug.Log("player pressed the w key");
			//move them in the direction forward * the scale (gridSize)
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
		//use the loop to iterate through our array of loseSpots
		for(int i = 0; i < loseSpot.Length; i++){
			//check the current one in our loop
			if (transform.position == loseSpot[i].position){
				//if the position is the same, reset our loser player
				transform.position = startPos;
				displayText.text = "try again ):";
			}
		}

		if (transform.position == winSpot.position) {
			//do the win thing
			displayText.text = "you win!!!";
		}

		//spacebar to reset the game
		if (Input.GetKeyDown(KeyCode.Space)){
			transform.position = startPos;
			displayText.text = "(reset)";
		}

	}
}
