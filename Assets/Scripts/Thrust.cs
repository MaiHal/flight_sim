using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust: MonoBehaviour {
	void Start () {
		
	}

	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			//transform.position += new Vector3(0f, 0f, 0.1f);
			Rigidbody rigidbody = GetComponent<Rigidbody>();
			rigidbody.AddForce(transform.up * -9000);
		} else {
			
		}
	}
}
