using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerpthree : MonoBehaviour
{
    public Color correctColor;
    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<answerboxp3>() != null)
        {
            GetComponent<Renderer>().material.color=correctColor;
            gameController.threeTwoCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color=neutralColor;
            gameController.threeTwoCorrect = 0;
        }

        gameController.correctCount = 4 + gameController.threeOneCorrect + gameController.threeTwoCorrect;
    }
}