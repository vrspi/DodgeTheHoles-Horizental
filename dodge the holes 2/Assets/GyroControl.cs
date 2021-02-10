using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float vitesse = 3f;
    private Vector2 LastmousePos;
    private void Start()
    {
        Time.timeScale = 1f;

    }
    private void Update()
    {
        //if (PlayerPrefs.GetInt("Systeme") == 1)
        //{
         //transform.Rotate(-Input.acceleration.x * Time.deltaTime * 70, 0, -Input.acceleration.z * Time.deltaTime * 70);
      //  transform.Rotate(-Input.acceleration.x * Time.deltaTime * 70, -Input.acceleration.z * Time.deltaTime * 70, 0);
        //}
        //transform.rotation = Quaternion.Euler(0, 0, -Input.acceleration.x * 25f);
        
        Touch touch = Input.GetTouch(0);
        Vector2 deltapos = Vector2.zero;
        if (Input.touchCount > 0)
        {

            Vector2 Currentmousepos = touch.position;

            if (LastmousePos == Vector2.zero)
            {
                LastmousePos = Currentmousepos;

            }
            deltapos = Currentmousepos - LastmousePos;
            LastmousePos = Currentmousepos;

            // Vector3 force = new Vector3(0f, 0, deltapos.y) * vitesse;

            rb.AddTorque(deltapos.y*Time.deltaTime,0f, -deltapos.x * Time.deltaTime);



        }


        if (touch.phase == TouchPhase.Ended)
        {
            LastmousePos = Vector2.zero;
        }

       
    }



    //private void Start()
    //{
    //    handle = new GameObject("handlee");

    //    handle.transform.position = transform.position;
    //    transform.SetParent(handle.transform);
    //    gyroEnabled = EnableGyro();
    //}
    //private bool EnableGyro()
    //{
    //    if (SystemInfo.supportsGyroscope)
    //    {
    //        gyro = Input.gyro;
    //        gyro.enabled = true;

    //        handle.transform.rotation = Quaternion.Euler(0f, 0f,0f);
    //        //rot = new Quaternion(0, 0, 1, 0);

    //        return true;

    //    }
    //    return false;
    //}
    //private void Update()
    //{ 
    //    if (gyroEnabled)
    //    {


    //        transform.eulerAngles = new Vector3(0f, 0f,gyro.attitude.eulerAngles.z-90);


    //    }
    //}
}
