using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public GameObject flag1;
    public GameObject flag2;

    public Camera camera2;
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

    }
}
