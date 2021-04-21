using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerp3 : MonoBehaviour
{
    public Color correctColor;
    public Color neutralColor;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<p3500m>() != null)
        {
            print("jumbo");
            GetComponent<Renderer>().material.color=correctColor;
            gameController.threeOneCorrect = 1;
        }

        else
        {
            GetComponent<Renderer>().material.color=neutralColor;
            gameController.threeOneCorrect = 0;
        }

        gameController.correctCount = 4 + gameController.threeOneCorrect + gameController.threeTwoCorrect;
        //print(gameController.correctCount);
    }
}