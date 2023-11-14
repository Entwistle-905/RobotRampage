using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bgMusic = null;

    void Start()
    {
        if (bgMusic == null)
        {
            bgMusic = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (bgMusic != this)
            {
                Destroy(this);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        
    }
}
