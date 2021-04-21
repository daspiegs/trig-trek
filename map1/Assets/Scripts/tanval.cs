using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanval : MonoBehaviour
{
    public Color correctColor;
    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<tanvalbox>() != null)
        {
            GetComponent<Renderer>().material.color=correctColor;
            gameController.tanvalCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color=neutralColor;
            gameController.tanvalCorrect = 0;
        }

        gameController.correctCount = 3 + gameController.tanvalCorrect;
    }
}
