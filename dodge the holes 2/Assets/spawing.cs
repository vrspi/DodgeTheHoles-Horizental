using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawing : MonoBehaviour
{
    public GameObject[] go;
    private float Target = 2f;
    float tr = 1.3f;
    // Start is called before the first frame update
    void Start()
    {Target -= 0.2f;
            tr += 6.11f;
        int x = Random.Range(0, 8);

        //Target -= 0.2f;
        //tr -= 6.1f;
        Instantiate(go[x], new Vector3(0.014f, 1.3f, tr) , Quaternion.Euler(90f,0f,0f));
        tr += 6.11f;
        x = Random.Range(0, 8);
        Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
        tr += 6.11f;
        x = Random.Range(0, 8);
        Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));



    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.z >= Target)
        { 
            int x = Random.Range(0, 8);
            if (x == 0)
            {

                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;

            }
            else if (x == 1)
            {

                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f)) ;
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 7)
            {

                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 6)
            {

                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 5)
            {
                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 4)
            {
                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 3)
            {
                Instantiate(go[x], new Vector3(-0.02f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
            else if (x == 2)
            {
                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr += 6.11f;
            }
            else
            {
                Instantiate(go[x], new Vector3(0.014f, 1.3f, tr), Quaternion.Euler(90f, 0f, 0f));
                Target += 4f;
                tr +=6.11f;
            }
        }
    }
}
