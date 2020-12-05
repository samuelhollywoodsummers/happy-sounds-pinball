﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public bool Flipper;

    // Update is called once per frame
    void Update()
    {
        if ((Flipper && Input.GetKey(KeyCode.RightControl)) || (!Flipper && Input.GetKey(KeyCode.LeftControl)))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
