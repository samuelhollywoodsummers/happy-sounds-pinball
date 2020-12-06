using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
       //movement speed in units per second
    private float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
            GetComponent<SliderJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<SliderJoint2D>().useMotor = false;
        }
   
    }
}
