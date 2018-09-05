using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWingForce : MonoBehaviour {
    GetVelocity aircraft;
    Vector3 angle;
    //public float ;

	// Use this for initialization
	void Start () {
        aircraft = gameObject.GetComponentInParent<GetVelocity>();
	}
	
	// Update is called once per frame
	void Update () {
        //GetParentVelocity();
        MtAngle();
    }

    void GetParentVelocity() {
        Debug.Log("x:"+aircraft.Vx+", y:" + aircraft.Vy + ", z:" + aircraft.Vz);
    }

    void MtAngle() {
        angle = gameObject.transform.localEulerAngles;
        Debug.Log("x" + (angle.x));
    }
}
