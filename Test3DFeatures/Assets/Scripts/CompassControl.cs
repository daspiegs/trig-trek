using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassControl : MonoBehaviour
{
    //private Vector3 offset = new Vector3(1, 0, 0);
    private float distance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance + Camera.main.transform.up * (-distance / 2);
    }
}
