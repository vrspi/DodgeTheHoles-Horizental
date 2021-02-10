using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playsnd : MonoBehaviour
{
    public AudioClip[] diks;
    public AudioSource audioSource;
    public static int i = 0;
    // Start is called before the first frame update
    void Start()
        
    {
        
        audioSource = this.GetComponent<AudioSource>();
            audioSource.clip = diks[i];

            if (audioSource.isPlaying == false)
            {
              

                audioSource.Play();
            audioSource.loop = true;
            Debug.Log("hani bedit");
              DontDestroyOnLoad(this);
             }
        i++;
    }

        // Update is called once per frame
        void Update()
        {
    
       

        }
    
}
