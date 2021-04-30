using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject distancebutton;
    public GameObject compassstartbutton;
    public GameObject compassendbutton;
    public GameObject AllDone;
    public float angle1;
    public float angle2;
    public Camera camera;
    float angley;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        distancebutton.SetActive(false);
        compassstartbutton.SetActive(false);
        compassendbutton.SetActive(false);
        AllDone.SetActive(false);
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        
        angley=camera.transform.localEulerAngles.y;
        if(angley==angle1){
            distancebutton.SetActive(true);
        }
        else{
             distancebutton.SetActive(false);
        }

         if(angley==angle2){
            compassstartbutton.SetActive(true);
        }
        else{
            compassstartbutton.SetActive(false);
        }

        if(angley==angle1 && i==1){
            compassendbutton.SetActive(true);
    
        }
        else{
            compassendbutton.SetActive(false);
        }

    }
    public void iupadatefunction(){
        i=1;
    }
}
