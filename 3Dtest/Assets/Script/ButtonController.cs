using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject distancebutton;
    public GameObject compassstartbutton;
    public GameObject compassendbutton;
    public Camera camera2;
    float angley;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        distancebutton.SetActive(false);
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        
        angley=camera2.transform.localEulerAngles.y;
        if(angley<=155 && angley>=145){
            distancebutton.SetActive(true);
        }
        else{
             distancebutton.SetActive(false);
        }

         if(angley<=212 && angley>=208){
            compassstartbutton.SetActive(true);
            i=1;
        }
        else{
            compassstartbutton.SetActive(false);
        }

        if(angley<=152 && angley>=148 && i==1){
            compassendbutton.SetActive(true);
    
        }
        else{
            compassendbutton.SetActive(false);
        }

    }
}
