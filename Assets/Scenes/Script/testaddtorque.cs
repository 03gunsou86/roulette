using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testaddtorque : MonoBehaviour {
    public float torque;
    /*public*/ Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
       // float turn = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.Return))
        {
            rb.AddTorque(transform.up * torque * 1000);
            Debug.Log("helloworld");
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            rb.AddTorque(transform.up * torque * -8000);
        }
    }
}
