using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float rotationSpeed = 0.03f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") /** rotationSpeed*/;
        float mouvementdown = Input.GetAxis("Vertical");
        transform.position += new Vector3(0f,mouvementdown * Time.deltaTime * 6);
        transform.Rotate(0, 0,rotation*Time.deltaTime*50);

    }
   public void mouvements()
    {
        transform.position += new Vector3(0f, -5 * Time.deltaTime);
        Debug.Log("Try");
    }
}
