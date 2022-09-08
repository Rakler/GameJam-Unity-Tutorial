using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointScript : MonoBehaviour
{
      public HingeJoint2D myJoint;
    public float speed;

    private JointMotor2D motor;
    private float inputSpeed;

    // Start is called before the first frame update
    void Start()
    {
        motor.maxMotorTorque = 100000f;
    }

    // Update is called once per frame
    void Update()
    {
        inputSpeed = Input.GetAxisRaw("Horizontal");
               
        motor.motorSpeed = inputSpeed * speed;
        myJoint.motor = motor;
    }
}
