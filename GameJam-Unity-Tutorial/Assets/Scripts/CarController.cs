using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D wheelF;
    public WheelJoint2D wheelB;
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

        if (inputSpeed != 0)
        { 
            motor.motorSpeed = inputSpeed * speed;
            
            // Comment out following line if you want to experiment having only the Back Wheel rotating
            wheelF.motor = motor;
            wheelB.motor = motor;
        }
        else
        {
            wheelF.useMotor = false;
            wheelB.useMotor = false;
        }
    }
}
