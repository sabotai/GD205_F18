using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavSeek : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		nav.destination = target.position;
	}
}
