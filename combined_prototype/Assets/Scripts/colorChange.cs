using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//color change script for answers

public class colorChange : MonoBehaviour
{
    public GameObject[] rightSpot = null;

    //change to true if it is something that is in the answer
    public bool isAnswer = false; 
    private GameObject objUnderMe = null;
    private int temp = gameController.correctCount; 

    //let's just try getting the colors here
    private gameController game; 

    private int where = 0; 


    void Start()
    {
        game = gameController.instance; 
        GetComponent<Renderer>().material.color = game.normalColor;
    }

    void Update()
    {
        temp = gameController.correctCount;
    }

    void OnMouseEnter()
    {
        if(where==0)
        {
            GetComponent<Renderer>().material.color = game.hoverColor;
        }
    }

    void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = game.clickColor;
    }

    void OnMouseUp()
    {
        //if object is on the right spot, change to correct color from game controller, else incorrect
        if(objUnderMe != null)
        {
            //(can just throw in random right spot for nonanswers if necessary)
            if(isAnswer == true && Array.IndexOf(rightSpot, objUnderMe) > -1)
            {
                GetComponent<Renderer>().material.color = game.correctColor;
                gameController.correctCount = temp + 1;
                where = 2;
            }
            
            else
            {
                GetComponent<Renderer>().material.color = game.incorrectColor;
                gameController.correctCount = temp;
                where = 1;
            }
        }

        else
        {
            GetComponent<Renderer>().material.color = game.hoverColor;
            where = 0; 
        }
    }

    void OnMouseExit()
    {
        if(where == 0)
        {
            GetComponent<Renderer>().material.color = game.normalColor;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<asquare>() != null)
        {
            objUnderMe = thingICollidedWith;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;
        if (thingICollidedWith.GetComponent<asquare>() != null)
        {
            objUnderMe = null;
        }
    }
}