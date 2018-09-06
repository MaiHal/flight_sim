using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWingForce : MonoBehaviour {
    GetVelocity aircraft;
    Vector3 mtangle;
    Vector3 velWing;
    float aoa;
    float flowVel;

    // Use this for initialization
    void Start () {
        aircraft = gameObject.GetComponentInParent<GetVelocity>();

    }
	
	// Update is called once per frame
	void Update () {
        //GetParentVelocity();
        MtAngle();
        FlowRotaion();
    }

    void GetParentVelocity() {
        Debug.Log("x:"+ aircraft.velocity.x+", y:" + aircraft.velocity.y + ", z:" + aircraft.velocity.z);
    }

    void MtAngle() {
        mtangle = gameObject.transform.localEulerAngles;
    }

    void FlowRotaion() {
        velWing = Quaternion.Euler(mtangle.x, mtangle.y, mtangle.z) * (aircraft.velocity);
        aoa = -1 * Mathf.Atan2(velWing.y, velWing.z) * Mathf.Rad2Deg;
        flowVel = Mathf.Sqrt(velWing.y*velWing.y + velWing.z* velWing.z);
        Debug.Log("flowVel:"+flowVel);
    }
}
