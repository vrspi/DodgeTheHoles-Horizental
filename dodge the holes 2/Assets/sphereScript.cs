using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sphereScript : MonoBehaviour
{
    public float thrust = 20f;
    public Rigidbody rb;
    private float target = 0f;
    Vector3 z;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(new Vector3(0, 0, 0), transform.position);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0, transform.position.z), 0.04f);
        Movement();
        if (transform.position.z >= target )
        {
            target += 15f;
            //if(thrust<=100f)
            thrust += 130f;
            rb.mass += 20;
        }
    }
  

    void Movement()
    {
        Vector3 movement = new Vector3(0f,0f,thrust);
        rb.AddForce(movement);
    }
    void OnCollisionEnter(Collision collision)
    { 
        if(collision.gameObject.name== "destroyer")
        {
            SceneManager.LoadScene(2);
        }

    }

    }

