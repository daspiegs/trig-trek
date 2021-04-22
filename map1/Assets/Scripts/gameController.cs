using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    //bools if in correct place
    public static int tanCorrect = 0;
    public static int fivehunCorrect = 0;
    public static int lengthCorrect = 0;
    //p2
    public static int tanvalCorrect = 0;
    //p3
    public static int threeOneCorrect = 0;
    public static int threeTwoCorrect = 0;

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

///////
    //int to measure if all correct
    public static int correctCount = tanCorrect + fivehunCorrect + lengthCorrect + tanvalCorrect + threeOneCorrect + threeTwoCorrect;

    //event to broadcast
    public static int nextProblem = 0;

    //stuff to dissapear
    public GameObject[] dissapearObjects;
    public GameObject[] appearObjects;
    public GameObject[] dissBox;
    public GameObject[] appearTwo;
    public GameObject[] appearProbFour;
    public GameObject[] appearFinish;

    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < dissapearObjects.Length; i++ )
        {
            dissapearObjects[i].SetActive(true);
        }

        for(int i = 0; i < appearObjects.Length; i++ )
        {
            appearObjects[i].SetActive(false);
        }

        for(int i = 0; i < appearTwo.Length; i++ )
        {
            appearTwo[i].SetActive(false);
        }

        for(int i = 0; i < appearProbFour.Length; i++ )
        {
            appearProbFour[i].SetActive(false);
        }

        for(int i = 0; i < appearFinish.Length; i++ )
        {
            appearFinish[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(correctCount == 3 && nextProblem == 0 ) 

        {
            StartCoroutine(waitThenContinue());
        }

        if(correctCount == 4 && nextProblem == 1 ) 
        {
            
            nextProblem = 2;

            for(int i = 0; i < dissBox.Length; i++)
            {
                dissBox[i].SetActive(false);
            }

            for(int i = 0; i < appearTwo.Length; i++ )
            {
                appearTwo[i].SetActive(true);
            }

            print("meow");
        }

        if(correctCount == 6 && nextProblem == 2) 
        {
            nextProblem = 3;

            print("quack");


            for(int i = 0; i < appearProbFour.Length; i++ )
            {
                appearProbFour[i].SetActive(true);
            }
        }

        if(estimateClicked == 1 && nextProblem == 3)
        {
            nextProblem = 4;


            for(int i = 0; i < appearProbFour.Length; i++)
            {
                if(appearProbFour[i].GetComponent<diswhenclick>() != null)
                {
                    appearProbFour[i].SetActive(false);
                }
            }

            print("BOOYA");

            for(int i = 0; i < appearFinish.Length; i++ )
            {
                appearFinish[i].SetActive(true);
            }
        }


    }

    IEnumerator waitThenContinue()
    {
        yield return new WaitForSeconds(1f);

        nextProblem = 1;

        for(int i = 0; i < dissapearObjects.Length; i++)
        {
            dissapearObjects[i].SetActive(false);
        }

        for(int i = 0; i < appearObjects.Length; i++ )
        {
            appearObjects[i].SetActive(true);

            if(appearObjects[i].GetComponent<newdragdrop>() != null)
            {
                appearObjects[i].GetComponent<newdragdrop>().enabled = true;
            }
        }
    }
}
