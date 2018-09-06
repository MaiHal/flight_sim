﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetVelocity : MonoBehaviour {
	public float time;
    public Vector3 velocity;
    public float latestX;
    public float latestY;
	public float latestZ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		getVelocity ();
		//timer();
	}

	void getVelocity(){
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		velocity.z = (this.gameObject.transform.localPosition.z - latestZ) / Time.deltaTime;
		velocity.y = (this.gameObject.transform.localPosition.y - latestY) / Time.deltaTime;
        velocity.x = (this.gameObject.transform.localPosition.x - latestX) / Time.deltaTime;
        latestZ = this.gameObject.transform.localPosition.z;
		latestY = this.gameObject.transform.localPosition.y;
        latestX = this.gameObject.transform.localPosition.x;
    }

	void timer(){
		time += Time.deltaTime;
		if (time >= 1.0f) {
			time = 0.0f;
		}
	}
}
