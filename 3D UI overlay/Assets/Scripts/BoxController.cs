using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(new Vector3(0.1f, 0.1f, 0.1f));
        }
    }

    public void StartRotate()
    {
        isRotating = true;
    }

    public void StopRotate()
    {
        isRotating = false;
    }
}
