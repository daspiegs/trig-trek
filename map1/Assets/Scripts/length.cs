using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class length : MonoBehaviour
{
    public Color correctColor;
    
    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<opposite>() != null)
        {
            GetComponent<Renderer>().material.color= correctColor;
            gameController.lengthCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color= neutralColor;
            gameController.lengthCorrect = 0;
        }

        gameController.correctCount = gameController.tanCorrect + gameController.fivehunCorrect + gameController.lengthCorrect;
}
    }