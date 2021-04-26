using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
public Camera camera1;
public Camera camera2;
public Camera camera3;


void Start()
{
    camera1.enabled = true;
    camera2.enabled = false;
    camera3.enabled = false;
}

void Update()
{
    if(Input.GetKeyDown(KeyCode.C))
    {
         camera1.enabled = true;
         camera2.enabled = false;
     
    }
    else if(Input.GetKeyDown(KeyCode.D))
    {
         camera1.enabled = false;
         camera2.enabled = true;
      
    }
   
}
}
