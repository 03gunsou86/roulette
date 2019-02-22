using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    //回転速度(rotatespeed)
    float raespeed = 0;
    public float torque;
    public Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.raespeed = 32;
        }
        transform.Rotate(0, this.raespeed,0);
        this.raespeed *= 0.99f;
        //float turn = Input.GetAxis("Horizontal");
        //rb.AddTorque(x, y, z);
	}
}
