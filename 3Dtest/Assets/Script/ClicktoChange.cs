using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoChange : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnMouseDown(){
        
        camera1.enabled = false;
        camera2.enabled = true;
     }

}
