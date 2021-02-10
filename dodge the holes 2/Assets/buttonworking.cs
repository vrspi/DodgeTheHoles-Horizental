using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonworking : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Systeme") == 1)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
        }
    }

}
