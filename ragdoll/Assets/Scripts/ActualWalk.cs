using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualWalk : MonoBehaviour {

    public Rigidbody pelvis;
    public float walkSpeed;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Motion();
        }
    }

    void Motion()
    {
        pelvis.AddRelativeForce(new Vector3(0.0f, 0.0f, 1.0f) * walkSpeed);
    }
}
