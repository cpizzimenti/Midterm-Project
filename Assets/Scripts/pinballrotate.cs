using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinballrotate : MonoBehaviour
{
    //Code from Nejo Flipper Tutorial 
    public float restPostion = 0f;
    public float pressedPostion = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;

    public string inputName;

    HingeJoint hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {
        JointSpring spring = new JointSpring();

        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if(Input.GetAxis(inputName)==1)
        {
            spring.targetPosition = pressedPostion;

        }
        else
        {
            spring.targetPosition = restPostion;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
