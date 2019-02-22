using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_AddTorque : MonoBehaviour {
    Rigidbody rb;
    public Vector3 v3;
    void Start () {
        v3 = new Vector3(0, 360, 0);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.X))
        {
            //rb.angularVelocity = v3;
            Quaternion deltaRotation = Quaternion.Euler(v3 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
            //rb.AddForce(Vector3.up);
        }
    }
}
