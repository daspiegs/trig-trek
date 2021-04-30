using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas2;
    public GameObject canvas3;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public GameObject arrow1;
    public GameObject arrow2;
    // Start is called before the first frame update
    void Start()
    {
        canvas2.SetActive(false);
        canvas3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(camera2.enabled == true){
           
            canvas2.SetActive(true);
            arrow1.SetActive(false);
            arrow2.SetActive(false);
        }
        else{
            canvas2.SetActive(false);
        }

           if(camera3.enabled == true){
           
            canvas3.SetActive(true);
            arrow1.SetActive(false);
            arrow2.SetActive(false);
        }
        else{
            canvas3.SetActive(false);
        }

        if(camera1.enabled == true){
            arrow1.SetActive(true);
            arrow2.SetActive(true);
        }
    }
}
