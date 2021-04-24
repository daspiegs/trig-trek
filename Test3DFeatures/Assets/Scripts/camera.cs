using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //movement variables
    // float rotationOnX;
    // float mouseSensitivity = 90f;
    public Transform player;
    // float inputX;
    // float inputZ;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject cube;

    private Vector3 above = new Vector3(0, 1, 0);
    public UnityEngine.UI.Text bearing;
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
        /*
        if(Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(speed*Vector3.forward * Time.deltaTime);  
        }  
         
        if(Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(speed*Vector3.back * Time.deltaTime);  
        }  
        */

        if(Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -1);  
        }  
        
        if(Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 1);  
        }

        // display bearing
        bearing.text = this.transform.rotation.eulerAngles.y.ToString();
    }

    public void changeLocToSphere()
    {
        this.transform.position = sphere.transform.position + above;
    }

    public void changeLocToCylinder()
    {
        this.transform.position = cylinder.transform.position + above;
    }

    public void changeLocToCube()
    {
        this.transform.position = cube.transform.position + above;
    }
}
 


