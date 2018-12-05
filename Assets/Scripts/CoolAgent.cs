using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoolAgent : MonoBehaviour {

	NavMeshAgent nav;
	//public Transform target;
	public string targetTag;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
	}
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(Collider col){
		if (col.gameObject.CompareTag(targetTag)){
			nav.destination = col.transform.position;
		}

	}
}
