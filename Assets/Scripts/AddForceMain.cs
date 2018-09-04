using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceMain : MonoBehaviour {
	public float time;
	public float Vz;
	public float Vy;
	public float latestZ;
	public float latestY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		//Debug.Log ("速度ベクトル: " + rigidbody.velocity);
		Vz = -(this.gameObject.transform.localPosition.z - latestZ) / Time.deltaTime;
		Vy = (this.gameObject.transform.localPosition.y - latestY) / Time.deltaTime;
		latestZ = this.gameObject.transform.localPosition.z;
		latestY = this.gameObject.transform.localPosition.y;

		time += Time.deltaTime;
		if (time >= 1.0f) {
			Debug.Log ("y:"+Vy+", z:"+Vz);
			time = 0.0f;
		}
	}
}
