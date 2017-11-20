using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

    public HingeJoint hj;
    public Transform trans;
    public bool reverse;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       if(Input.GetKey(KeyCode.W))
        {
            Motion();
        }
	}

    void Motion()
    {
        JointSpring js = hj.spring;
        js.targetPosition = trans.eulerAngles.x;
        if (js.targetPosition > 180)
        {
            js.targetPosition = js.targetPosition - 360;
        }
        js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min + 5, hj.limits.max - 5);
        if (reverse)
        {
            js.targetPosition = js.targetPosition * -1;
        }
        hj.spring = js;
    }

    
}
