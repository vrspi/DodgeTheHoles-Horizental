using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinssystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("coins").ToString();
    }

}
