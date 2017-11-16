using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

	//get bones and joints and rigidbodies
	public GameObject RightArm;
	public GameObject RightElbow;
	public GameObject LeftArm;
	public GameObject LeftElbow;
	public float punchForce;

	private CharacterJoint RightArmJoint;
	private HingeJoint RightElbowJoint;
	private Joint LeftArmJoint;
	private Joint LeftElbowJoint;

	private Rigidbody RARB;
	private Rigidbody RERB;
	private Rigidbody LARB;
	private Rigidbody LERB;


	// Use this for initialization
	void Start () {
		//assign joints
		RightArmJoint = RightArm.GetComponent<CharacterJoint> ();
		RightElbowJoint = RightElbow.GetComponent<HingeJoint> ();
		LeftArmJoint = LeftArm.GetComponent<Joint> ();
		LeftElbowJoint = LeftElbow.GetComponent<Joint> ();

		//assign rigidbodies
		RARB = RightArm.GetComponent<Rigidbody> ();
		RERB = RightElbow.GetComponent<Rigidbody> ();
		LARB = LeftArm.GetComponent<Rigidbody> ();
		LERB = LeftElbow.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		ArmMoveTest ();
	}

	void ArmMoveTest()
	{
		if (gameObject.tag == "P1") 
		{
			if (Input.GetKeyDown (KeyCode.D)) {
				RERB.AddRelativeForce (new Vector3 (0.0f, 0.0f, punchForce));
			}
			if (Input.GetKeyDown (KeyCode.A)) {
				LERB.AddRelativeForce (new Vector3 (0.0f, 0.0f, punchForce));
			}
		}
		if (gameObject.tag == "P2") {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				RERB.AddRelativeForce (new Vector3 (0.0f, 0.0f, punchForce));
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				LERB.AddRelativeForce (new Vector3 (0.0f, 0.0f, punchForce));
			}
		}
	}

}
