using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tan : MonoBehaviour
{
    public Color correctColor;

    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

// it's colliding with a new thing so it goes to else

        if(thingICollidedWith.GetComponent<yellow>() != null && gameController.tanCorrect == 0)
        {
            GetComponent<Renderer>().material.color=correctColor;
            gameController.tanCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color=neutralColor;
            gameController.tanCorrect = 0;
        }

        gameController.correctCount = gameController.tanCorrect + gameController.fivehunCorrect + gameController.lengthCorrect;
    }

    // public void OnCollisionExit2D(Collision2D collision)
    // {
    //     GameObject thingICollidedWith = collision.gameObject;
    //     if (thingICollidedWith.GetComponent<square>() != null)
    //     {
    //         objUnderMe = null;
    //     }
    // }

    // public void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.GameObject == "Square yellow")
    //     {
            
    //     }

    //     // if(collision.GameObject == incorrectObj)
    //     // {
    //     //     transform.GetComponent<Renderer>().material.color= incorrectColor;
    //     // }


    // }

}
