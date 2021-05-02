using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    private bool angle3done = false;
    private bool angle2done = false;
    private bool dist3done = false;
    private bool dist2done = false;
    public GameObject AllDone;
    public GameObject AllDone2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (angle3done && angle2done && (dist3done || dist2done))
        {
            AllDone.SetActive(true);
            AllDone2.SetActive(true);
        }
    }

    public void angle3()
    {
        angle3done = true;
        //print("done1");
    }

    public void angle2()
    {
        angle2done = true;
        //print("done2");
    }

    public void dist3()
    {
        dist3done = true;
        //print("done3");
    }

    public void dist2()
    {
        dist2done = true;
        //print("done4");
    }

}
