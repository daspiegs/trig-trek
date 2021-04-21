using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newdragdrop : MonoBehaviour
{
    private bool isDragging = false;
    private GameObject objUnderMe = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follow mouse pos when dragging
        if(isDragging == true)
        {
            //mouse position relative to frame
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            //make obj follow mouse
            transform.position = mousePos;
        }  

    }

    //when mouse on sprite, drag sprite
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        // The the mouse is released, stop dragging the sprite.
        isDragging = false;

        // If there is a obj under me right now, snap to it.
        if(objUnderMe != null)
        {
            Vector2 newPosition = objUnderMe.transform.position;
            newPosition += new Vector2(0, 0.5f);
            transform.position = newPosition;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;

        if(thingICollidedWith.GetComponent<square>() != null)
        {
            objUnderMe = thingICollidedWith;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        GameObject thingICollidedWith = collision.gameObject;
        if (thingICollidedWith.GetComponent<square>() != null)
        {
            objUnderMe = null;
        }
    }
}

