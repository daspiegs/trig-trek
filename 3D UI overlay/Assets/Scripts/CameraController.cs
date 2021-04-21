using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //movement variables
    // float rotationOnX;
    // float mouseSensitivity = 90f;
    public Transform player;
    // float inputX;
    // float inputZ;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Hide mouse cursor
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        //take mouse input
        // float mouseY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSensitivity;
        // float m_X = Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensitivity;

        // //Rotation camera up and down;
        // rotationOnX -= mouseY;
        // rotationOnX = Mathf.Clamp(rotationOnX, -90f, 90f);
        // transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);

        // //Rotate left and right
        // player.Rotate(Vector3.up * m_X);

        //move?
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(speed * Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 1);
        }

    }
}



