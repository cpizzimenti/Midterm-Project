using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinballrotate : MonoBehaviour
{
    //Code from Nejo Flipper Tutorial 
    public float restPostion = 0f;//position of flipper at rest
    public float pressedPostion = 45f;//angle flipper will turn
    public float hitStrength = 100000f;//how much strength on hit
    public float flipperDamper = 1500f;

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
