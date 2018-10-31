using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public GameObject blueprint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit hit = new RaycastHit();

		if (Physics.Raycast(laser, out hit, 1000f)){
			if (Input.GetMouseButton(0)){
				GetComponent<AudioSource>().Play();
				Debug.Log("you done hit smthn");
				if (hit.rigidbody){
					//hit.rigidbody.AddForce(Vector3.forward * 99999f);
					hit.rigidbody.AddForce(Random.insideUnitSphere * 9999f);

					if (hit.transform.gameObject.GetComponent<AudioSource>()){
						hit.transform.gameObject.GetComponent<AudioSource>().Play();
					}
				}
			} else {
				GetComponent<AudioSource>().Stop();
			}

			if (Input.GetMouseButton(1)){
				Instantiate(blueprint, hit.point, Quaternion.identity);

			}
		}
	}
}
