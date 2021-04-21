using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fivehun : MonoBehaviour
{
    public Color correctColor;
    
    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<adjacent>() != null)
        {
            GetComponent<Renderer>().material.color= correctColor;
            gameController.fivehunCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color= neutralColor;
            gameController.fivehunCorrect = 0;
        }
        gameController.correctCount = gameController.tanCorrect + gameController.fivehunCorrect + gameController.lengthCorrect;
}
    }


