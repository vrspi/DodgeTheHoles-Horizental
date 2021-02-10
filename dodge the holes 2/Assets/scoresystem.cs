using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoresystem : MonoBehaviour
{
   private float iniPos;
    public TMP_Text text;
    public int score;
    public float target = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        score = int.Parse(text.text);
        iniPos = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= target)
        {
            Debug.Log("hna");
            score++;
            target = target + 2f;
            text.text = score.ToString();
            iniPos = transform.position.z;
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + score);

        }
    }
}
