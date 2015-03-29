﻿using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public Transform LightSource;
	public Renderer rend;
	public float Heat;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		lighting ();
	}
	
	// Update is called once per frame
	void Update () {
		lighting ();
	}

	void lighting(){
		RaycastHit hit;
//		LayerMask mask = ~(1 << LayerMask.NameToLayer ("zombie")|1<<LayerMask.NameToLayer("vision")|1<<LayerMask.NameToLayer("check"));
		Ray ray = new Ray (transform.position, LightSource.position - transform.position);
		if (Physics.Raycast (ray, out hit, 400)) {
			if (hit.transform.tag == "Light") {
				rend.material.color = Color.white;
			}
		else {
			rend.material.color = Color.black;
		}
	}
	}
}
