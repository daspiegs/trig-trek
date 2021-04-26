using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Angledisplay : MonoBehaviour
{
    public Camera camera;
    public Text scoreText;  // public if you want to drag your text object in there manually
    float angle;
    
    // Start is called before the first frame update
    void Start()
    {
         scoreText = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        angle=210 - (camera.transform.localEulerAngles.y - (camera.transform.localEulerAngles.y % 1));
         scoreText.text ="Angle="+angle.ToString();
    }
}
