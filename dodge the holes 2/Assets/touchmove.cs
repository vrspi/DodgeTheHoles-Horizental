using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchmove : MonoBehaviour
{
    private int x = 0;
    private int y = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
      
        if (x == 1)
        { transform.position += new Vector3(0f, -0.6f * Time.deltaTime); 
        
        }
        if (x == 2)
        {
            transform.position += new Vector3(0f, 0.6f * Time.deltaTime);

        }
        if (y == 1)
        {
            transform.Rotate(0, 0, -1* Time.deltaTime * 23);

        }
        if (y == 2)
        {
            transform.Rotate(0, 0,  Time.deltaTime * 23);

        }
    }
    public void mouvements()
    {
        x = 1;
    }
    public void mouvementsUP()
    {
        x = 2;
    }
    public void Nomouvements()
    {
        x = 0;
    }
    public void left()
    {
        y = 1;
    }
    public void right()
    {
        y = 2;
    }
    public void noRotatio()
    {
        y = 0;
    }
}
