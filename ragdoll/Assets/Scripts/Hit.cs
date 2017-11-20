using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	public Rigidbody target;
	public Rigidbody rb;
	public float punchForce;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	void OnCollisionEnter(Collision col)
	{
		target = col.rigidbody;
		target.AddRelativeForce (col.relativeVelocity * punchForce);
		Debug.Log(col.relativeVelocity);
	}
}
