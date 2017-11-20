using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour {

	public Rigidbody rb;
	public float torque;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Turn();
		Jump();
	}

    void Turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
			rb.AddRelativeTorque (new Vector3 (1, 0, 0) * torque);
        }
		if (Input.GetKey(KeyCode.A))
		{
			rb.AddRelativeTorque (new Vector3 (-1, 0, 0) * torque);
		}
    }

	void Jump()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddRelativeForce (new Vector3 (.8f, 0, .4f) * torque * 20);
		}
	}
}
