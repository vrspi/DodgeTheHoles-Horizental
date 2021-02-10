using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemVariation : MonoBehaviour
{

    public void system1()
    {
        PlayerPrefs.SetInt("Systeme",1);
        PlayerPrefs.SetInt("Checked", 1);
    }
    public void system2()
    {
        PlayerPrefs.SetInt("Systeme", 2);
        PlayerPrefs.SetInt("Checked", 1);
    }

}
