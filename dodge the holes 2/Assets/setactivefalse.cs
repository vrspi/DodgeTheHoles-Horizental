using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactivefalse : MonoBehaviour
{
    public GameObject Obj1;
    public GameObject Obj2;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Checked") == 1)
        {
            Obj1.SetActive(false);
            Obj2.SetActive(false);
        }
    }
}
