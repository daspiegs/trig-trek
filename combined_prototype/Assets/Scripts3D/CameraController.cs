using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 velocity = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
        //transform.Translate(velocity);

        //Rotation
        /*
        float rotation =0;
        if (Input.GetKey (KeyCode.LeftArrow))
            rotation -= 1;
        if (Input.GetKey (KeyCode.RightArrow))
            rotation += 1;
        transform.Rotate (0, rotation, 0);
        */
    }

}
