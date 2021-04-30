using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocker : MonoBehaviour
{
    public Camera camera2;
    float angley;
    public float speed = 0.1f;
    public float targetangle1;
    public float leftangle1;
    public float rightangle1;
      public float targetangle2;
    public float leftangle2;
    public float rightangle2;
      private bool lockTurning;
    // track when turning should be unlocked
    private float lockTimer;
    // set how long to lock the camera, currently 1 second
    private float lockLength = 1;
    // a flag to prevent the camera from locking constantly
    private bool lockImmune = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angley=camera2.transform.localEulerAngles.y;
        //Vector3 velocity = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
        //transform.Translate (velocity);

        //Rotation
        float rotation =0;
        if (Input.GetKey (KeyCode.LeftArrow) && !lockTurning){
            rotation -= 1;}
        
        if (Input.GetKey (KeyCode.RightArrow) && !lockTurning){
            rotation += 1;}

        transform.Rotate (0, rotation, 0);

        if (Time.time >= lockTimer)
            {
                lockTurning = false;
            }


        if(angley<=rightangle1 && angley>=leftangle1 && !lockImmune){

            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetangle1, transform.rotation.eulerAngles.z);
            lockTimer = Time.time + lockLength;
            lockTurning = true;
            lockImmune = true;
        }

        if(angley<=rightangle2 && angley>=leftangle2 && !lockImmune){
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetangle2, transform.rotation.eulerAngles.z);
            lockTimer = Time.time + lockLength;
            lockTurning = true;
            lockImmune = true;
        }

        if ((angley > rightangle1 || angley < leftangle1) && (angley > rightangle2 || angley < leftangle2))
        {
            lockImmune = false;
        }

    }


    
}
