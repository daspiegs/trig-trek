using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas2;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        canvas2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(camera2.enabled == true){
           
            canvas2.SetActive(true);
        }
        else{
            canvas2.SetActive(false);
        }
    }
}
