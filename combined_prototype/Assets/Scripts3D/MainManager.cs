using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    //stuff for UI showing up 
    public static int fiveHunMeasured = 0;
    public static int ninetyMeasured = 0;
    public static int thirtyMeasured = 0;
    public GameObject check90;
    public GameObject check30;
    public GameObject check500;

    //
    private bool angle3done = false;
    private bool angle2done = false;
    private bool dist3done = false;
    private bool dist2done = false;
    public GameObject AllDone;
    public GameObject AllDone2;

    // Start is called before the first frame update
    void Start()
    {
        check90.SetActive(false);
        check30.SetActive(false);
        check500.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (angle3done && angle2done && (dist3done || dist2done))
        {
            AllDone.SetActive(true);
            AllDone2.SetActive(true);
        }

        //show dist check 
        if (dist3done || dist2done)
        {
            check500.SetActive(true);
        }

        //show 90 check
        if (angle3done)
        {
            check90.SetActive(true);
        }

        //show 30 check 
        if (angle2done)
        {
            check30.SetActive(true);
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
