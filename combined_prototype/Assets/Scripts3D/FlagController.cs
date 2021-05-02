using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public GameObject flag1;
    public GameObject flag2;
    public GameObject flag3;
    public GameObject flag4;
    public Camera camera2;
    public Camera camera3;
    float angley;
  
    // Start is called before the first frame update
    void Start()
    {
        flag1.SetActive(false);
        flag2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    if(camera2.enabled == true){
        angley=camera2.transform.localEulerAngles.y;

         if(angley<=212 && angley>=208){
            flag1.SetActive(true);
            
        }
        else{
            flag1.SetActive(false);
        }

        if(angley<=152 && angley>=148){
            flag2.SetActive(true);
    
        }
        else{
            flag2.SetActive(false);
        }
    }
    else{
         flag1.SetActive(false);
         flag2.SetActive(false);
    }

     if(camera3.enabled == true){
        angley=camera3.transform.localEulerAngles.y;

         if(angley<=229 && angley>=225){
            flag3.SetActive(true);
            
        }
        else{
            flag3.SetActive(false);
        }

        if(angley<=334 && angley>=330){
            flag4.SetActive(true);
    
        }
        else{
            flag4.SetActive(false);
        }
    }
    else{
         flag3.SetActive(false);
         flag4.SetActive(false);
    }

    }
}
