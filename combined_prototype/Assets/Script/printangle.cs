using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printangle : MonoBehaviour
{
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void printfunction(){
        print(camera2.transform.localEulerAngles.y);
    }
}
