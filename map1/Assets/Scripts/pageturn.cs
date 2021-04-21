using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageturn : MonoBehaviour
{
    public int pageIndex = 0;

    public GameObject[] pageOptions;



    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < pageOptions.Length; i++ )
        {
            pageOptions[i].SetActive( pageIndex==i );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameController.nextProblem ==1)
        {
            pageIndex = 2;
            for(int i = 0; i < pageOptions.Length; i++ )
            {   
                pageOptions[i].SetActive( pageIndex==i );
            }
        }
    }

}

