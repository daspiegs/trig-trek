using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estClick : MonoBehaviour
{
    //when mouse on sprite, drag sprite
    public void OnMouseDown()
    {
        gameController.estimateClicked = 1;
        print("clickedCalc");
    }
}
