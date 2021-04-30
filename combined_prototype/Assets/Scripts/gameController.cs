using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    //
    public static gameController instance;

    //final
    public static int estimateClicked = 0;

    //color time
    public Color hoverColor;
    public Color normalColor = Color.white;
    public Color clickColor;
    public Color correctColor; 
    public Color incorrectColor;

    //int to measure correct placements
    public static int correctCount = 0;

    //event to broadcast
    public static int nextProblem = 0;

    //stuff to appear and dissapear
    public GameObject[] problem1;
    public GameObject[] problem2;
    public GameObject[] problem3;
    public GameObject[] problem4;
    public GameObject[] calculate;
    public GameObject[] appearFinish;

    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < problem1.Length; i++ )
        {
            problem1[i].SetActive(true);
        }

        for(int i = 0; i < problem2.Length; i++ )
        {
            problem2[i].SetActive(false);
        }

        for(int i = 0; i < problem3.Length; i++ )
        {
            problem3[i].SetActive(false);
        }

        for(int i = 0; i < problem4.Length; i++ )
        {
            problem4[i].SetActive(false);
        }

        for(int i = 0; i < calculate.Length; i++ )
        {
            calculate[i].SetActive(false);
        }

        for(int i = 0; i < appearFinish.Length; i++ )
        {
            appearFinish[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(correctCount == 3 && nextProblem == 0)
        {
            print("p1donzos");
            StartCoroutine(waitThenContinue(problem1, problem2));
            nextProblem = 1;
        }

        if(correctCount == 4 && nextProblem == 1 ) 
        {
            print("p2donzos");
            StartCoroutine(waitThenContinue(problem2, problem3));
            nextProblem = 2;
        }

        if(correctCount == 5 && nextProblem == 2) 
        {
            print("p3donzos");
            StartCoroutine(waitThenContinue(problem3, problem4));
            nextProblem = 3;
        }

        if(correctCount == 6 && nextProblem == 3) 
        {
            print("p4donzos");
            StartCoroutine(waitThenContinue(problem4, calculate));
            nextProblem = 4;
        }

        if(estimateClicked == 1 && nextProblem == 4)
        {
            print("calcdonzos");
            StartCoroutine(waitThenContinue(calculate, appearFinish));
            nextProblem = 5;
            print("BOOYA");
        }
    }

//switch out problem stuff function
    IEnumerator waitThenContinue(GameObject[] bye, GameObject[] hi)
    {
        yield return new WaitForSeconds(1f);

        for(int i = 0; i < bye.Length; i++)
        {
            bye[i].SetActive(false);
        }

        for(int i = 0; i < hi.Length; i++ )
        {
            hi[i].SetActive(true);

            if(hi[i].GetComponent<dragdropobj>() != null)
            {
                hi[i].GetComponent<dragdropobj>().enabled = true;
            }
        }
    }
}
