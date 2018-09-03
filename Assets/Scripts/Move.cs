using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private Vector3 m_powerDir  = Vector3.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			//transform.position += new Vector3(0f, 0f, 0.1f);
			Rigidbody rigidbody = GetComponent<Rigidbody>();
			rigidbody.AddForce(0,100,0);
		} else {
			
		}
	}
}
