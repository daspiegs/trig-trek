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
    public UnityEngine.UI.Text bearingUI;
    private float bearing;
    public float speed = 5;
    private float sphereFromCyl = 84;
    private float cubeFromCyl = 45;
    private float sphereFromCub = 190;
    private float cylFromCub = 225;
    private string loc = "cylinder";
    private string[] locs = { "cube", "cylinder" };
    private bool lockTurning;
    private float lockTimer;
    private float lockLength = 1;
    private bool lockImmune = false;
    private int snapRange = 10;

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
        // update camera bearing
        bearing = this.transform.rotation.eulerAngles.y;
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

        lockTurn();

        //print(Time.time);
        //print(lockTimer);

        if (Time.time >= lockTimer)
        {
            lockTurning = false;
        }

        if(Input.GetKey(KeyCode.LeftArrow) && !lockTurning)  
        {  
            this.transform.Rotate(Vector3.up, -1);  
        }  
        
        if(Input.GetKey(KeyCode.RightArrow) && !lockTurning)  
        {  
            this.transform.Rotate(Vector3.up, 1);  
        }

        // display bearing
        bearingUI.text = bearing.ToString();
    }

    private void lockTurn()
    {
        if (loc == "cylinder")
        {
            // check if the player is looking approximately at the object.
            if (System.Math.Abs(bearing - sphereFromCyl) < snapRange)
            {
                snapHelper(sphereFromCyl);
                lockTurnHelper();
                //this.transform.LookAt(sphere.transform);
                //print(lockImmune);
                return;
            }
            else if (System.Math.Abs(bearing - cubeFromCyl) < snapRange)
            {
                snapHelper(cubeFromCyl);
                lockTurnHelper();
                //print(lockImmune);
                return;
            }
        }

        if (loc == "cube")
        {
            if (System.Math.Abs(bearing - sphereFromCub) < snapRange)
            {
                snapHelper(sphereFromCub);
                lockTurnHelper();
                //print("locked");
                return;
            }
            else if (System.Math.Abs(bearing - cylFromCub) < snapRange)
            {
                snapHelper(cylFromCub);
                lockTurnHelper();
                //print("locked");
                return;
            }
        }
        lockImmune = false;
        return;
    }

    private void lockTurnHelper()
    {
        lockTurning = true;
        if (!lockImmune)
        {
            lockTimer = Time.time + lockLength;
        }
        lockImmune = true;
    }

    private void snapHelper(float snapY)
    {
        if (!lockImmune)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, snapY, transform.rotation.eulerAngles.z);
        }
    }

    public void changeLocToSphere()
    {
        this.transform.position = sphere.transform.position + above;
        loc = "sphere";
    }

    public void changeLocToCylinder()
    {
        this.transform.position = cylinder.transform.position + above;
        loc = "cylinder";
    }

    public void changeLocToCube()
    {
        this.transform.position = cube.transform.position + above;
        loc = "cube";
    }
}
 


